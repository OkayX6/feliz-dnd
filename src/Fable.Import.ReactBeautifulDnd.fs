// ts2fable 0.8.0
module rec Fable.Import.ReactBeautifulDnd

open System
open Fable
open Fable.Core
open Fable.Core.JS
open Browser.Types


type [<AllowNullLiteral>] IExports =
    abstract DragDropContext: DragDropContextStatic
    abstract Droppable: DroppableStatic
    abstract Draggable: DraggableStatic
    abstract resetServerContext: unit -> unit

type Omit<'T> = 'T

type [<AllowNullLiteral>] Position =
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] BoxModel =
    abstract marginBox: Rect with get, set
    abstract borderBox: Rect with get, set
    abstract paddingBox: Rect with get, set
    abstract contentBox: Rect with get, set
    abstract border: Spacing with get, set
    abstract padding: Spacing with get, set
    abstract margin: Spacing with get, set

type [<AllowNullLiteral>] Rect =
    abstract top: float with get, set
    abstract right: float with get, set
    abstract bottom: float with get, set
    abstract left: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set
    abstract center: Position with get, set

type [<AllowNullLiteral>] Spacing =
    abstract top: float with get, set
    abstract right: float with get, set
    abstract bottom: float with get, set
    abstract left: float with get, set

/// IDs
type Id =
    string

type DraggableId =
    Id

type DroppableId =
    Id

type TypeId =
    Id

type ContextId =
    Id

type ElementId =
    Id

type [<StringEnum>] [<RequireQualifiedAccess>] DroppableMode =
    | Standard
    | Virtual

type [<AllowNullLiteral>] DroppableDescriptor =
    abstract id: DroppableId with get, set
    abstract ``type``: TypeId with get, set
    abstract mode: DroppableMode with get, set

type [<AllowNullLiteral>] DraggableDescriptor =
    abstract id: DraggableId with get, set
    abstract index: int with get, set
    abstract droppableId: DroppableId with get, set
    abstract ``type``: TypeId with get, set

type [<AllowNullLiteral>] DraggableOptions =
    abstract canDragInteractiveElements: bool with get, set
    abstract shouldRespectForcePress: bool with get, set
    abstract isEnabled: bool with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] Direction =
    | Horizontal
    | Vertical

type [<AllowNullLiteral>] VerticalAxis =
    abstract direction: string with get, set
    abstract line: string with get, set
    abstract start: string with get, set
    abstract ``end``: string with get, set
    abstract size: string with get, set
    abstract crossAxisLine: string with get, set
    abstract crossAxisStart: string with get, set
    abstract crossAxisEnd: string with get, set
    abstract crossAxisSize: string with get, set

type [<AllowNullLiteral>] HorizontalAxis =
    abstract direction: string with get, set
    abstract line: string with get, set
    abstract start: string with get, set
    abstract ``end``: string with get, set
    abstract size: string with get, set
    abstract crossAxisLine: string with get, set
    abstract crossAxisStart: string with get, set
    abstract crossAxisEnd: string with get, set
    abstract crossAxisSize: string with get, set

type Axis =
    U2<VerticalAxis, HorizontalAxis>

type [<AllowNullLiteral>] ScrollSize =
    abstract scrollHeight: float with get, set
    abstract scrollWidth: float with get, set

type [<AllowNullLiteral>] ScrollDifference =
    abstract value: Position with get, set
    abstract displacement: Position with get, set

type [<AllowNullLiteral>] ScrollDetails =
    abstract initial: Position with get, set
    abstract current: Position with get, set
    abstract max: Position with get, set
    abstract diff: ScrollDifference with get, set

type [<AllowNullLiteral>] Placeholder =
    abstract client: BoxModel with get, set
    abstract tagName: string with get, set
    abstract display: string with get, set

type [<AllowNullLiteral>] DraggableDimension =
    abstract descriptor: DraggableDescriptor with get, set
    abstract placeholder: Placeholder with get, set
    abstract client: BoxModel with get, set
    abstract page: BoxModel with get, set
    abstract displaceBy: Position with get, set

type [<AllowNullLiteral>] Scrollable =
    abstract pageMarginBox: Rect with get, set
    abstract frameClient: BoxModel with get, set
    abstract scrollSize: ScrollSize with get, set
    abstract shouldClipSubject: bool with get, set
    abstract scroll: ScrollDetails with get, set

type [<AllowNullLiteral>] PlaceholderInSubject =
    abstract increasedBy: Position option with get, set
    abstract placeholderSize: Position with get, set
    abstract oldFrameMaxScroll: Position option with get, set

type [<AllowNullLiteral>] DroppableSubject =
    abstract page: BoxModel with get, set
    abstract withPlaceholder: PlaceholderInSubject option with get, set
    abstract active: Rect option with get, set

type [<AllowNullLiteral>] DroppableDimension =
    abstract descriptor: DroppableDescriptor with get, set
    abstract axis: Axis with get, set
    abstract isEnabled: bool with get, set
    abstract isCombineEnabled: bool with get, set
    abstract client: BoxModel with get, set
    abstract isFixedOnPage: bool with get, set
    abstract page: BoxModel with get, set
    abstract frame: Scrollable option with get, set
    abstract subject: DroppableSubject with get, set

type [<AllowNullLiteral>] DraggableLocation =
    abstract droppableId: DroppableId with get, set
    abstract index: int with get, set

type [<AllowNullLiteral>] DraggableIdMap =
    [<EmitIndexer>] abstract Item: id: string -> obj with get, set

type [<AllowNullLiteral>] DroppableIdMap =
    [<EmitIndexer>] abstract Item: id: string -> obj with get, set

type [<AllowNullLiteral>] DraggableDimensionMap =
    [<EmitIndexer>] abstract Item: key: string -> DraggableDimension with get, set

type [<AllowNullLiteral>] DroppableDimensionMap =
    [<EmitIndexer>] abstract Item: key: string -> DroppableDimension with get, set

type [<AllowNullLiteral>] Displacement =
    abstract draggableId: DraggableId with get, set
    abstract shouldAnimate: bool with get, set

type [<AllowNullLiteral>] DisplacementMap =
    [<EmitIndexer>] abstract Item: key: string -> Displacement with get, set

type [<AllowNullLiteral>] DisplacedBy =
    abstract value: float with get, set
    abstract point: Position with get, set

type [<AllowNullLiteral>] Combine =
    abstract draggableId: DraggableId with get, set
    abstract droppableId: DroppableId with get, set

type [<AllowNullLiteral>] DisplacementGroups =
    abstract all: ResizeArray<DraggableId> with get, set
    abstract visible: DisplacementMap with get, set
    abstract invisible: DraggableIdMap with get, set

type [<AllowNullLiteral>] ReorderImpact =
    abstract ``type``: string with get, set
    abstract destination: DraggableLocation with get, set

type [<AllowNullLiteral>] CombineImpact =
    abstract ``type``: string with get, set
    abstract combine: Combine with get, set

type ImpactLocation =
    U2<ReorderImpact, CombineImpact>

type [<AllowNullLiteral>] Displaced =
    abstract forwards: DisplacementGroups with get, set
    abstract backwards: DisplacementGroups with get, set

type [<AllowNullLiteral>] DragImpact =
    abstract displaced: DisplacementGroups with get, set
    abstract displacedBy: DisplacedBy with get, set
    abstract at: ImpactLocation option with get, set

type [<AllowNullLiteral>] ClientPositions =
    abstract selection: Position with get, set
    abstract borderBoxCenter: Position with get, set
    abstract offset: Position with get, set

type [<AllowNullLiteral>] PagePositions =
    abstract selection: Position with get, set
    abstract borderBoxCenter: Position with get, set
    abstract offset: Position with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] MovementMode =
    | [<CompiledName "FLUID">] FLUID
    | [<CompiledName "SNAP">] SNAP

type [<AllowNullLiteral>] DragPositions =
    abstract client: ClientPositions with get, set
    abstract page: PagePositions with get, set

type [<AllowNullLiteral>] DraggableRubric =
    abstract draggableId: DraggableId with get, set
    abstract mode: MovementMode with get, set
    abstract source: DraggableLocation with get, set

type [<AllowNullLiteral>] DragStart =
    inherit BeforeCapture
    inherit DraggableRubric
    abstract ``type``: TypeId with get, set
    abstract source: DraggableLocation with get, set
    abstract mode: MovementMode with get, set

type [<AllowNullLiteral>] BeforeCapture =
    abstract draggableId: DraggableId with get, set
    abstract mode: MovementMode with get, set

type [<AllowNullLiteral>] DragUpdate =
    inherit DragStart
    abstract destination: DraggableLocation option with get, set
    abstract combine: Combine option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] DropReason =
    | [<CompiledName "DROP">] DROP
    | [<CompiledName "CANCEL">] CANCEL

type [<AllowNullLiteral>] DropResult =
    inherit DragUpdate
    abstract reason: DropReason with get, set

type [<AllowNullLiteral>] ScrollOptions =
    abstract shouldPublishImmediately: bool with get, set

type [<AllowNullLiteral>] LiftRequest =
    abstract draggableId: DraggableId with get, set
    abstract scrollOptions: ScrollOptions with get, set

type [<AllowNullLiteral>] Critical =
    abstract draggable: DraggableDescriptor with get, set
    abstract droppable: DroppableDescriptor with get, set

type [<AllowNullLiteral>] Viewport =
    abstract frame: Rect with get, set
    abstract scroll: ScrollDetails with get, set

type [<AllowNullLiteral>] LiftEffect =
    abstract inVirtualList: bool with get, set
    abstract effected: DraggableIdMap with get, set
    abstract displacedBy: DisplacedBy with get, set

type [<AllowNullLiteral>] DimensionMap =
    abstract draggables: DraggableDimensionMap with get, set
    abstract droppables: DroppableDimensionMap with get, set

type [<AllowNullLiteral>] DroppablePublish =
    abstract droppableId: DroppableId with get, set
    abstract scroll: Position with get, set

type [<AllowNullLiteral>] Published =
    abstract additions: ResizeArray<DraggableDimension> with get, set
    abstract removals: ResizeArray<DraggableId> with get, set
    abstract modified: ResizeArray<DroppablePublish> with get, set

type [<AllowNullLiteral>] CompletedDrag =
    abstract critical: Critical with get, set
    abstract result: DropResult with get, set
    abstract impact: DragImpact with get, set
    abstract afterCritical: LiftEffect with get, set

type [<AllowNullLiteral>] IdleState =
    abstract phase: string with get, set
    abstract completed: CompletedDrag option with get, set
    abstract shouldFlush: bool with get, set

type [<AllowNullLiteral>] DraggingState =
    abstract phase: string with get, set
    abstract isDragging: obj with get, set
    abstract critical: Critical with get, set
    abstract movementMode: MovementMode with get, set
    abstract dimensions: DimensionMap with get, set
    abstract initial: DragPositions with get, set
    abstract current: DragPositions with get, set
    abstract impact: DragImpact with get, set
    abstract viewport: Viewport with get, set
    abstract afterCritical: LiftEffect with get, set
    abstract onLiftImpact: DragImpact with get, set
    abstract isWindowScrollAllowed: bool with get, set
    abstract scrollJumpRequest: Position option with get, set
    abstract forceShouldAnimate: bool option with get, set

type [<AllowNullLiteral>] CollectingState =
    inherit Omit<DraggingState>
    abstract phase: string with get, set

type [<AllowNullLiteral>] DropPendingState =
    inherit Omit<DraggingState>
    abstract phase: string with get, set
    abstract isWaiting: bool with get, set
    abstract reason: DropReason with get, set

type [<AllowNullLiteral>] DropAnimatingState =
    abstract phase: string with get, set
    abstract completed: CompletedDrag with get, set
    abstract newHomeClientOffset: Position with get, set
    abstract dropDuration: float with get, set
    abstract dimensions: DimensionMap with get, set

type State =
    U5<IdleState, DraggingState, CollectingState, DropPendingState, DropAnimatingState>

type StateWhenUpdatesAllowed =
    U2<DraggingState, CollectingState>

type [<AllowNullLiteral>] Announce =
    [<Emit "$0($1...)">] abstract Invoke: message: string -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] InOutAnimationMode =
    | None
    | Open
    | Close

type [<AllowNullLiteral>] ResponderProvided =
    abstract announce: Announce with get, set

type [<AllowNullLiteral>] OnBeforeCaptureResponder =
    [<Emit "$0($1...)">] abstract Invoke: before: BeforeCapture -> unit

type [<AllowNullLiteral>] OnBeforeDragStartResponder =
    [<Emit "$0($1...)">] abstract Invoke: start: DragStart -> unit

type [<AllowNullLiteral>] OnDragStartResponder =
    [<Emit "$0($1...)">] abstract Invoke: start: DragStart * provided: ResponderProvided -> unit

type [<AllowNullLiteral>] OnDragUpdateResponder =
    [<Emit "$0($1...)">] abstract Invoke: update: DragUpdate * provided: ResponderProvided -> unit

type [<AllowNullLiteral>] OnDragEndResponder =
    [<Emit "$0($1...)">] abstract Invoke: result: DropResult * provided: ResponderProvided -> unit

type [<AllowNullLiteral>] Responders =
    abstract onBeforeCapture: OnBeforeCaptureResponder option with get, set
    abstract onBeforeDragStart: OnBeforeDragStartResponder option with get, set
    abstract onDragStart: OnDragStartResponder option with get, set
    abstract onDragUpdate: OnDragUpdateResponder option with get, set
    abstract onDragEnd: OnDragEndResponder with get, set

type [<AllowNullLiteral>] StopDragOptions =
    abstract shouldBlockNextClick: bool with get, set

type [<AllowNullLiteral>] DragActions =
    abstract drop: (StopDragOptions -> unit) with get, set
    abstract cancel: (StopDragOptions -> unit) with get, set
    abstract isActive: (unit -> bool) with get, set
    abstract shouldRespectForcePress: (unit -> bool) with get, set

type [<AllowNullLiteral>] FluidDragActions =
    inherit DragActions
    abstract move: (Position -> unit) with get, set

type [<AllowNullLiteral>] SnapDragActions =
    inherit DragActions
    abstract moveUp: (unit -> unit) with get, set
    abstract moveDown: (unit -> unit) with get, set
    abstract moveRight: (unit -> unit) with get, set
    abstract moveLeft: (unit -> unit) with get, set

type [<AllowNullLiteral>] PreDragActions =
    abstract isActive: (unit -> bool) with get, set
    abstract shouldRespectForcePress: (unit -> bool) with get, set
    abstract fluidLift: (Position -> FluidDragActions) with get, set
    abstract snapLift: (unit -> SnapDragActions) with get, set
    abstract abort: (unit -> unit) with get, set

type [<AllowNullLiteral>] TryGetLockOptions =
    abstract sourceEvent: Event option with get, set

type [<AllowNullLiteral>] TryGetLock =
    [<Emit "$0($1...)">] abstract Invoke: draggableId: DraggableId * ?forceStop: (unit -> unit) * ?options: TryGetLockOptions -> PreDragActions option

type [<AllowNullLiteral>] SensorAPI =
    abstract tryGetLock: TryGetLock with get, set
    abstract canGetLock: (DraggableId -> bool) with get, set
    abstract isLockClaimed: (unit -> bool) with get, set
    abstract tryReleaseLock: (unit -> unit) with get, set
    abstract findClosestDraggableId: (Event -> DraggableId option) with get, set
    abstract findOptionsForDraggable: (DraggableId -> DraggableOptions option) with get, set

type [<AllowNullLiteral>] Sensor =
    [<Emit "$0($1...)">] abstract Invoke: api: SensorAPI -> unit

/// DragDropContext
type [<AllowNullLiteral>] DragDropContextProps =
    abstract onBeforeCapture: before: BeforeCapture -> unit
    abstract onBeforeDragStart: initial: DragStart -> unit
    abstract onDragStart: initial: DragStart * provided: ResponderProvided -> unit
    abstract onDragUpdate: initial: DragUpdate * provided: ResponderProvided -> unit
    abstract onDragEnd: result: DropResult * provided: ResponderProvided -> unit
    abstract children: React.ReactElement option with get, set
    abstract dragHandleUsageInstructions: string option with get, set
    abstract nonce: string option with get, set
    abstract enableDefaultSensors: bool option with get, set
    abstract sensors: ResizeArray<Sensor> option with get, set

type DragDropContext =
    React.Component<DragDropContextProps, obj>

type [<AllowNullLiteral>] DragDropContextStatic =
    [<EmitConstructor>] abstract Create: unit -> DragDropContext

/// Droppable
type [<AllowNullLiteral>] DroppableProvidedProps =
    abstract ``data-rbd-droppable-context-id``: string with get, set
    abstract ``data-rbd-droppable-id``: DroppableId with get, set

type [<AllowNullLiteral>] DroppableProvided =
    abstract innerRef: element: HTMLElement option -> obj
    abstract placeholder: React.ReactElement option with get, set
    abstract droppableProps: DroppableProvidedProps with get, set

type [<AllowNullLiteral>] DroppableStateSnapshot =
    abstract isDraggingOver: bool with get, set
    abstract draggingOverWith: DraggableId option with get, set
    abstract draggingFromThisWith: DraggableId option with get, set
    abstract isUsingPlaceholder: bool with get, set

type [<AllowNullLiteral>] DroppableProps =
    abstract droppableId: DroppableId with get, set
    abstract ``type``: TypeId option with get, set
    abstract mode: DroppableMode option with get, set
    abstract isDropDisabled: bool option with get, set
    abstract isCombineEnabled: bool option with get, set
    abstract direction: Direction option with get, set
    abstract ignoreContainerClipping: bool option with get, set
    abstract renderClone: DraggableChildrenFn option with get, set
    abstract getContainerForClone: (unit -> React.ReactElementType<HTMLElement>) option with get, set
    abstract children: provided: DroppableProvided * snapshot: DroppableStateSnapshot -> React.ReactElementType<HTMLElement>

type Droppable = React.Component<DroppableProps, obj>

type [<AllowNullLiteral>] DroppableStatic =
    [<EmitConstructor>] abstract Create: unit -> Droppable

/// Draggable
type [<AllowNullLiteral>] DropAnimation =
    abstract duration: float with get, set
    abstract curve: string with get, set
    abstract moveTo: Position with get, set
    abstract opacity: float option with get, set
    abstract scale: float option with get, set

type [<AllowNullLiteral>] NotDraggingStyle =
    abstract transform: string option with get, set
    abstract transition: string option with get, set

type [<AllowNullLiteral>] DraggingStyle =
    abstract position: string with get, set
    abstract top: float with get, set
    abstract left: float with get, set
    abstract boxSizing: string with get, set
    abstract width: float with get, set
    abstract height: float with get, set
    abstract transition: string with get, set
    abstract transform: string option with get, set
    abstract zIndex: float with get, set
    abstract opacity: float option with get, set
    abstract pointerEvents: string with get, set

type [<AllowNullLiteral>] DraggableProvidedDraggableProps =
    abstract style: U2<DraggingStyle, NotDraggingStyle> option with get, set
    abstract ``data-rbd-draggable-context-id``: string with get, set
    abstract ``data-rbd-draggable-id``: string with get, set
    abstract onTransitionEnd: (TransitionEvent -> unit) option with get, set

type [<AllowNullLiteral>] DraggableProvidedDragHandleProps =
    abstract ``data-rbd-drag-handle-draggable-id``: DraggableId with get, set
    abstract ``data-rbd-drag-handle-context-id``: ContextId with get, set
    abstract ``aria-describedby``: ElementId with get, set
    abstract role: string with get, set
    abstract tabIndex: float with get, set
    abstract draggable: bool with get, set
    abstract onDragStart: (DragEvent -> unit) option with get, set

type [<AllowNullLiteral>] DraggableProvided =
    abstract innerRef: element: HTMLElement option -> obj
    abstract draggableProps: DraggableProvidedDraggableProps with get, set
    abstract dragHandleProps: DraggableProvidedDragHandleProps option with get, set

type [<AllowNullLiteral>] DraggableStateSnapshot =
    abstract isDragging: bool with get, set
    abstract isDropAnimating: bool with get, set
    abstract dropAnimation: DropAnimation option with get, set
    abstract draggingOver: DroppableId option with get, set
    abstract combineWith: DraggableId option with get, set
    abstract combineTargetFor: DraggableId option with get, set
    abstract mode: MovementMode option with get, set

// type [<AllowNullLiteral>] DraggableChildrenFn =
//     [<Emit "$0($1...)">] abstract Invoke: provided: DraggableProvided * snapshot: DraggableStateSnapshot * rubric: DraggableRubric -> React.ReactElementType<HTMLElement>

type DraggableChildrenFn = DraggableProvided -> DraggableStateSnapshot -> DraggableRubric -> React.ReactElement

type [<AllowNullLiteral>] DraggableProps =
    abstract draggableId: DraggableId with get, set
    abstract index: int with get, set
    abstract children: DraggableChildrenFn with get, set
    abstract isDragDisabled: bool option with get, set
    abstract disableInteractiveElementBlocking: bool option with get, set
    abstract shouldRespectForcePress: bool option with get, set

type Draggable = React.Component<DraggableProps, obj>

type [<AllowNullLiteral>] DraggableStatic =
    [<EmitConstructor>] abstract Create: unit -> Draggable