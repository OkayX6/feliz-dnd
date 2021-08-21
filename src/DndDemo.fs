module App.DndDemo

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.ReactBeautifulDnd
open Feliz
open Feliz.ReactBeautifulDnd
open type Feliz.style
open type Feliz.Html


let spreadProps (o: obj) =
  [ for propName in JS.Constructors.Object.keys(o) ->
      prop.custom (propName, o?(propName)) ]

let spreadStyleProps (o: obj) =
  [ for propName in JS.Constructors.Object.keys(o) ->
      style.custom (propName, o?(propName)) ]

[<RequireQualifiedAccess>]
module Array =
  let removeItem index (array: _[]) =
    if index < 0 || index >= array.Length then failwith $"Invalid index: {index} in array of length {array.Length}"
    let res = Array.zeroCreate (array.Length - 1)
    for i = 0 to index - 1 do res.[i] <- array.[i]
    for i = index + 1 to array.Length - 1 do res.[i-1] <- array.[i]
    res

  let insertAt index value (array: _[]) =
    if index < 0 || index > array.Length then failwith $"Invalid index: {index} in array of length {array.Length}"
    let res = Array.zeroCreate (array.Length + 1)
    Array.blit array 0 res 0 index
    res.[index] <- value
    Array.blit array index res (index+1) (array.Length - index)
    res
    

 // fake data generator
let getItems count =
  Array.init count (fun k -> 
    {|id = $"item-${k}"
      content = $"item ${k}"|}
  )


  // a little function to help us with reordering the result
let reorder (list: 'a[], startIndex, endIndex) =
  let toReorder = list.[startIndex]
  list
  |> Array.removeItem startIndex
  |> Array.insertAt endIndex toReorder


let grid = 8


let getItemStyle (isDragging, draggableStyle: U2<DraggingStyle, NotDraggingStyle> option) = [
  // some basic styles to make the items look a bit nicer
  style.userSelect.none
  padding (grid * 2)
  margin (0, 0, grid, 0)

  // change background colour if dragging
  backgroundColor (if isDragging then "lightgreen" else "grey")

  // styles we need to apply on draggables
  // NOTE: this actually doesn't really work well (see Fable's warning on type test)
  match draggableStyle with
  | Some(U2.Case1 draggingStyle) ->
    yield! spreadStyleProps draggingStyle
  | Some(U2.Case2 notDraggingStyle) ->
    yield! spreadStyleProps notDraggingStyle
  | None -> ()
]

let getListStyle isDraggingOver = [
  backgroundColor (if isDraggingOver then "lightblue" else "lightgrey")
  padding grid
  width 250
]


[<ReactComponent>]
let Dnd () =
  let items, setItems = React.useState (getItems 10)

  let onDragEnd (result: DropResult) _ =
    // dropped outside the list
    match result.destination with
    | Some destination ->
      let newItems = reorder (items, result.source.index, destination.index)
      setItems newItems
    | None -> ()

  ReactBeautifulDnd.dragDropContext [ DragDropContextProps.OnDragEnd onDragEnd ] [
    ReactBeautifulDnd.droppable "droppable-zone" (fun provided snapshot ->
      div [
        yield! spreadProps provided.droppableProps
        prop.ref (fun (elt: Element) -> provided.innerRef (Some (elt :?> HTMLElement)) |> ignore)
        prop.style (getListStyle snapshot.isDraggingOver)
        prop.children [
          for i = 0 to items.Length - 1 do
            let item = items.[i]
            ReactBeautifulDnd.draggable
              [ DraggableProps.Custom ("key", item.id)
                DraggableProps.DraggableId item.id
                DraggableProps.Index i
              ]
              (fun provided snapshot _ ->
                div [
                  prop.ref (fun (elt: Element) -> provided.innerRef (Some (elt :?> HTMLElement)) |> ignore)
                  yield! spreadProps provided.draggableProps
                  yield! spreadProps provided.dragHandleProps
                  prop.style (getItemStyle(snapshot.isDragging, provided.draggableProps.style))
                  prop.text item.content
                ]
              )

          yield! provided.placeholder |> Option.toList
        ]
      ]
    )
  ]