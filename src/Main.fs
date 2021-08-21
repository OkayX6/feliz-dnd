module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.scss"

ReactDOM.render(
    DndDemo.Dnd(),
    document.getElementById "feliz-app"
)