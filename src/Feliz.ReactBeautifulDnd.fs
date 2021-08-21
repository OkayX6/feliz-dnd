module Feliz.ReactBeautifulDnd

open Fable
open Fable.Core
open Fable.Core.JsInterop
open Fable.React.Helpers
open Fable.Import.ReactBeautifulDnd


[<RequireQualifiedAccess>]
type DroppableProps =
  | DroppableId of string
  | Children of (DroppableProvided -> DroppableStateSnapshot -> React.ReactElement)

[<RequireQualifiedAccess>]
type DraggableProps =
  | DraggableId of string
  | Index of int
  | Children of DraggableChildrenFn
  | Custom of string * obj


[<RequireQualifiedAccess>]
type DragDropContextProps =
  | OnDragEnd of (DropResult -> ResponderProvided -> unit)


type ReactBeautifulDnd =
  static member dragDropContext (props: DragDropContextProps list) children =
    let propsObject = keyValueList CaseRules.LowerFirst props // converts Props to JS object
    ofImport "DragDropContext" "react-beautiful-dnd" propsObject children

  static member droppable droppableId body =
    let propsObject = keyValueList CaseRules.LowerFirst [
      DroppableProps.DroppableId droppableId
      DroppableProps.Children body
    ]
    ofImport "Droppable" "react-beautiful-dnd" propsObject []

  static member draggable props (body: DraggableChildrenFn) =
    let normalProps = keyValueList CaseRules.LowerFirst [
      for p in props do
        match p with
        | DraggableProps.Custom _ -> ()
        | _ -> p
      DraggableProps.Children body
    ]

    let customProps = createObj [
      for p in props do
        match p with
        | DraggableProps.Custom (key, value) -> key ==> value
        | _ -> ()
    ]

    let propsObject = Fable.Core.JS.Constructors.Object.assign(normalProps, customProps)

    ofImport "Draggable" "react-beautiful-dnd" propsObject []