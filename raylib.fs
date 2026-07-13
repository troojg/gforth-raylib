\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library raylib
s" raylib" add-lib
\c #include "raylib.h"

\ ----===< int constants >===-----
#6	constant RAYLIB_VERSION_MAJOR
#0	constant RAYLIB_VERSION_MINOR
#0	constant RAYLIB_VERSION_PATCH

\ ---===< float constants >===----
\ 3.141593e0	fconstant PI \ Already defined in gforth
0.017453e0	fconstant DEG2RAD
57.295776e0	fconstant RAD2DEG

\ --------===< enums >===---------
\ enum ConfigFlags
#64	constant FLAG_VSYNC_HINT
#2	constant FLAG_FULLSCREEN_MODE
#4	constant FLAG_WINDOW_RESIZABLE
#8	constant FLAG_WINDOW_UNDECORATED
#128	constant FLAG_WINDOW_HIDDEN
#512	constant FLAG_WINDOW_MINIMIZED
#1024	constant FLAG_WINDOW_MAXIMIZED
#2048	constant FLAG_WINDOW_UNFOCUSED
#4096	constant FLAG_WINDOW_TOPMOST
#256	constant FLAG_WINDOW_ALWAYS_RUN
#16	constant FLAG_WINDOW_TRANSPARENT
#8192	constant FLAG_WINDOW_HIGHDPI
#16384	constant FLAG_WINDOW_MOUSE_PASSTHROUGH
#32768	constant FLAG_BORDERLESS_WINDOWED_MODE
#32	constant FLAG_MSAA_4X_HINT
#65536	constant FLAG_INTERLACED_HINT
\ enum TraceLogLevel
#0	constant LOG_ALL
#1	constant LOG_TRACE
#2	constant LOG_DEBUG
#3	constant LOG_INFO
#4	constant LOG_WARNING
#5	constant LOG_ERROR
#6	constant LOG_FATAL
#7	constant LOG_NONE
\ enum KeyboardKey
#0	constant KEY_NULL
#39	constant KEY_APOSTROPHE
#44	constant KEY_COMMA
#45	constant KEY_MINUS
#46	constant KEY_PERIOD
#47	constant KEY_SLASH
#48	constant KEY_ZERO
#49	constant KEY_ONE
#50	constant KEY_TWO
#51	constant KEY_THREE
#52	constant KEY_FOUR
#53	constant KEY_FIVE
#54	constant KEY_SIX
#55	constant KEY_SEVEN
#56	constant KEY_EIGHT
#57	constant KEY_NINE
#59	constant KEY_SEMICOLON
#61	constant KEY_EQUAL
#65	constant KEY_A
#66	constant KEY_B
#67	constant KEY_C
#68	constant KEY_D
#69	constant KEY_E
#70	constant KEY_F
#71	constant KEY_G
#72	constant KEY_H
#73	constant KEY_I
#74	constant KEY_J
#75	constant KEY_K
#76	constant KEY_L
#77	constant KEY_M
#78	constant KEY_N
#79	constant KEY_O
#80	constant KEY_P
#81	constant KEY_Q
#82	constant KEY_R
#83	constant KEY_S
#84	constant KEY_T
#85	constant KEY_U
#86	constant KEY_V
#87	constant KEY_W
#88	constant KEY_X
#89	constant KEY_Y
#90	constant KEY_Z
#91	constant KEY_LEFT_BRACKET
#92	constant KEY_BACKSLASH
#93	constant KEY_RIGHT_BRACKET
#96	constant KEY_GRAVE
#32	constant KEY_SPACE
#256	constant KEY_ESCAPE
#257	constant KEY_ENTER
#258	constant KEY_TAB
#259	constant KEY_BACKSPACE
#260	constant KEY_INSERT
#261	constant KEY_DELETE
#262	constant KEY_RIGHT
#263	constant KEY_LEFT
#264	constant KEY_DOWN
#265	constant KEY_UP
#266	constant KEY_PAGE_UP
#267	constant KEY_PAGE_DOWN
#268	constant KEY_HOME
#269	constant KEY_END
#280	constant KEY_CAPS_LOCK
#281	constant KEY_SCROLL_LOCK
#282	constant KEY_NUM_LOCK
#283	constant KEY_PRINT_SCREEN
#284	constant KEY_PAUSE
#290	constant KEY_F1
#291	constant KEY_F2
#292	constant KEY_F3
#293	constant KEY_F4
#294	constant KEY_F5
#295	constant KEY_F6
#296	constant KEY_F7
#297	constant KEY_F8
#298	constant KEY_F9
#299	constant KEY_F10
#300	constant KEY_F11
#301	constant KEY_F12
#340	constant KEY_LEFT_SHIFT
#341	constant KEY_LEFT_CONTROL
#342	constant KEY_LEFT_ALT
#343	constant KEY_LEFT_SUPER
#344	constant KEY_RIGHT_SHIFT
#345	constant KEY_RIGHT_CONTROL
#346	constant KEY_RIGHT_ALT
#347	constant KEY_RIGHT_SUPER
#348	constant KEY_KB_MENU
#320	constant KEY_KP_0
#321	constant KEY_KP_1
#322	constant KEY_KP_2
#323	constant KEY_KP_3
#324	constant KEY_KP_4
#325	constant KEY_KP_5
#326	constant KEY_KP_6
#327	constant KEY_KP_7
#328	constant KEY_KP_8
#329	constant KEY_KP_9
#330	constant KEY_KP_DECIMAL
#331	constant KEY_KP_DIVIDE
#332	constant KEY_KP_MULTIPLY
#333	constant KEY_KP_SUBTRACT
#334	constant KEY_KP_ADD
#335	constant KEY_KP_ENTER
#336	constant KEY_KP_EQUAL
#4	constant KEY_BACK
#5	constant KEY_MENU
#24	constant KEY_VOLUME_UP
#25	constant KEY_VOLUME_DOWN
\ enum MouseButton
#0	constant MOUSE_BUTTON_LEFT
#1	constant MOUSE_BUTTON_RIGHT
#2	constant MOUSE_BUTTON_MIDDLE
#3	constant MOUSE_BUTTON_SIDE
#4	constant MOUSE_BUTTON_EXTRA
#5	constant MOUSE_BUTTON_FORWARD
#6	constant MOUSE_BUTTON_BACK
\ enum MouseCursor
#0	constant MOUSE_CURSOR_DEFAULT
#1	constant MOUSE_CURSOR_ARROW
#2	constant MOUSE_CURSOR_IBEAM
#3	constant MOUSE_CURSOR_CROSSHAIR
#4	constant MOUSE_CURSOR_POINTING_HAND
#5	constant MOUSE_CURSOR_RESIZE_EW
#6	constant MOUSE_CURSOR_RESIZE_NS
#7	constant MOUSE_CURSOR_RESIZE_NWSE
#8	constant MOUSE_CURSOR_RESIZE_NESW
#9	constant MOUSE_CURSOR_RESIZE_ALL
#10	constant MOUSE_CURSOR_NOT_ALLOWED
\ enum GamepadButton
#0	constant GAMEPAD_BUTTON_UNKNOWN
#1	constant GAMEPAD_BUTTON_LEFT_FACE_UP
#2	constant GAMEPAD_BUTTON_LEFT_FACE_RIGHT
#3	constant GAMEPAD_BUTTON_LEFT_FACE_DOWN
#4	constant GAMEPAD_BUTTON_LEFT_FACE_LEFT
#5	constant GAMEPAD_BUTTON_RIGHT_FACE_UP
#6	constant GAMEPAD_BUTTON_RIGHT_FACE_RIGHT
#7	constant GAMEPAD_BUTTON_RIGHT_FACE_DOWN
#8	constant GAMEPAD_BUTTON_RIGHT_FACE_LEFT
#9	constant GAMEPAD_BUTTON_LEFT_TRIGGER_1
#10	constant GAMEPAD_BUTTON_LEFT_TRIGGER_2
#11	constant GAMEPAD_BUTTON_RIGHT_TRIGGER_1
#12	constant GAMEPAD_BUTTON_RIGHT_TRIGGER_2
#13	constant GAMEPAD_BUTTON_MIDDLE_LEFT
#14	constant GAMEPAD_BUTTON_MIDDLE
#15	constant GAMEPAD_BUTTON_MIDDLE_RIGHT
#16	constant GAMEPAD_BUTTON_LEFT_THUMB
#17	constant GAMEPAD_BUTTON_RIGHT_THUMB
\ enum GamepadAxis
#0	constant GAMEPAD_AXIS_LEFT_X
#1	constant GAMEPAD_AXIS_LEFT_Y
#2	constant GAMEPAD_AXIS_RIGHT_X
#3	constant GAMEPAD_AXIS_RIGHT_Y
#4	constant GAMEPAD_AXIS_LEFT_TRIGGER
#5	constant GAMEPAD_AXIS_RIGHT_TRIGGER
\ enum MaterialMapIndex
#0	constant MATERIAL_MAP_ALBEDO
#1	constant MATERIAL_MAP_METALNESS
#2	constant MATERIAL_MAP_NORMAL
#3	constant MATERIAL_MAP_ROUGHNESS
#4	constant MATERIAL_MAP_OCCLUSION
#5	constant MATERIAL_MAP_EMISSION
#6	constant MATERIAL_MAP_HEIGHT
#7	constant MATERIAL_MAP_CUBEMAP
#8	constant MATERIAL_MAP_IRRADIANCE
#9	constant MATERIAL_MAP_PREFILTER
#10	constant MATERIAL_MAP_BRDF
\ enum ShaderLocationIndex
#0	constant SHADER_LOC_VERTEX_POSITION
#1	constant SHADER_LOC_VERTEX_TEXCOORD01
#2	constant SHADER_LOC_VERTEX_TEXCOORD02
#3	constant SHADER_LOC_VERTEX_NORMAL
#4	constant SHADER_LOC_VERTEX_TANGENT
#5	constant SHADER_LOC_VERTEX_COLOR
#6	constant SHADER_LOC_MATRIX_MVP
#7	constant SHADER_LOC_MATRIX_VIEW
#8	constant SHADER_LOC_MATRIX_PROJECTION
#9	constant SHADER_LOC_MATRIX_MODEL
#10	constant SHADER_LOC_MATRIX_NORMAL
#11	constant SHADER_LOC_VECTOR_VIEW
#12	constant SHADER_LOC_COLOR_DIFFUSE
#13	constant SHADER_LOC_COLOR_SPECULAR
#14	constant SHADER_LOC_COLOR_AMBIENT
#15	constant SHADER_LOC_MAP_ALBEDO
#16	constant SHADER_LOC_MAP_METALNESS
#17	constant SHADER_LOC_MAP_NORMAL
#18	constant SHADER_LOC_MAP_ROUGHNESS
#19	constant SHADER_LOC_MAP_OCCLUSION
#20	constant SHADER_LOC_MAP_EMISSION
#21	constant SHADER_LOC_MAP_HEIGHT
#22	constant SHADER_LOC_MAP_CUBEMAP
#23	constant SHADER_LOC_MAP_IRRADIANCE
#24	constant SHADER_LOC_MAP_PREFILTER
#25	constant SHADER_LOC_MAP_BRDF
#26	constant SHADER_LOC_VERTEX_BONEIDS
#27	constant SHADER_LOC_VERTEX_BONEWEIGHTS
#28	constant SHADER_LOC_MATRIX_BONETRANSFORMS
#29	constant SHADER_LOC_VERTEX_INSTANCETRANSFORM
\ enum ShaderUniformDataType
#0	constant SHADER_UNIFORM_FLOAT
#1	constant SHADER_UNIFORM_VEC2
#2	constant SHADER_UNIFORM_VEC3
#3	constant SHADER_UNIFORM_VEC4
#4	constant SHADER_UNIFORM_INT
#5	constant SHADER_UNIFORM_IVEC2
#6	constant SHADER_UNIFORM_IVEC3
#7	constant SHADER_UNIFORM_IVEC4
#8	constant SHADER_UNIFORM_UINT
#9	constant SHADER_UNIFORM_UIVEC2
#10	constant SHADER_UNIFORM_UIVEC3
#11	constant SHADER_UNIFORM_UIVEC4
#12	constant SHADER_UNIFORM_SAMPLER2D
\ enum ShaderAttributeDataType
#0	constant SHADER_ATTRIB_FLOAT
#1	constant SHADER_ATTRIB_VEC2
#2	constant SHADER_ATTRIB_VEC3
#3	constant SHADER_ATTRIB_VEC4
\ enum PixelFormat
#1	constant PIXELFORMAT_UNCOMPRESSED_GRAYSCALE
#2	constant PIXELFORMAT_UNCOMPRESSED_GRAY_ALPHA
#3	constant PIXELFORMAT_UNCOMPRESSED_R5G6B5
#4	constant PIXELFORMAT_UNCOMPRESSED_R8G8B8
#5	constant PIXELFORMAT_UNCOMPRESSED_R5G5B5A1
#6	constant PIXELFORMAT_UNCOMPRESSED_R4G4B4A4
#7	constant PIXELFORMAT_UNCOMPRESSED_R8G8B8A8
#8	constant PIXELFORMAT_UNCOMPRESSED_R32
#9	constant PIXELFORMAT_UNCOMPRESSED_R32G32B32
#10	constant PIXELFORMAT_UNCOMPRESSED_R32G32B32A32
#11	constant PIXELFORMAT_UNCOMPRESSED_R16
#12	constant PIXELFORMAT_UNCOMPRESSED_R16G16B16
#13	constant PIXELFORMAT_UNCOMPRESSED_R16G16B16A16
#14	constant PIXELFORMAT_COMPRESSED_DXT1_RGB
#15	constant PIXELFORMAT_COMPRESSED_DXT1_RGBA
#16	constant PIXELFORMAT_COMPRESSED_DXT3_RGBA
#17	constant PIXELFORMAT_COMPRESSED_DXT5_RGBA
#18	constant PIXELFORMAT_COMPRESSED_ETC1_RGB
#19	constant PIXELFORMAT_COMPRESSED_ETC2_RGB
#20	constant PIXELFORMAT_COMPRESSED_ETC2_EAC_RGBA
#21	constant PIXELFORMAT_COMPRESSED_PVRT_RGB
#22	constant PIXELFORMAT_COMPRESSED_PVRT_RGBA
#23	constant PIXELFORMAT_COMPRESSED_ASTC_4x4_RGBA
#24	constant PIXELFORMAT_COMPRESSED_ASTC_8x8_RGBA
\ enum TextureFilter
#0	constant TEXTURE_FILTER_POINT
#1	constant TEXTURE_FILTER_BILINEAR
#2	constant TEXTURE_FILTER_TRILINEAR
#3	constant TEXTURE_FILTER_ANISOTROPIC_4X
#4	constant TEXTURE_FILTER_ANISOTROPIC_8X
#5	constant TEXTURE_FILTER_ANISOTROPIC_16X
\ enum TextureWrap
#0	constant TEXTURE_WRAP_REPEAT
#1	constant TEXTURE_WRAP_CLAMP
#2	constant TEXTURE_WRAP_MIRROR_REPEAT
#3	constant TEXTURE_WRAP_MIRROR_CLAMP
\ enum CubemapLayout
#0	constant CUBEMAP_LAYOUT_AUTO_DETECT
#1	constant CUBEMAP_LAYOUT_LINE_VERTICAL
#2	constant CUBEMAP_LAYOUT_LINE_HORIZONTAL
#3	constant CUBEMAP_LAYOUT_CROSS_THREE_BY_FOUR
#4	constant CUBEMAP_LAYOUT_CROSS_FOUR_BY_THREE
\ enum FontType
#0	constant FONT_DEFAULT
#1	constant FONT_BITMAP
#2	constant FONT_SDF
\ enum BlendMode
#0	constant BLEND_ALPHA
#1	constant BLEND_ADDITIVE
#2	constant BLEND_MULTIPLIED
#3	constant BLEND_ADD_COLORS
#4	constant BLEND_SUBTRACT_COLORS
#5	constant BLEND_ALPHA_PREMULTIPLY
#6	constant BLEND_CUSTOM
#7	constant BLEND_CUSTOM_SEPARATE
\ enum Gesture
#0	constant GESTURE_NONE
#1	constant GESTURE_TAP
#2	constant GESTURE_DOUBLETAP
#4	constant GESTURE_HOLD
#8	constant GESTURE_DRAG
#16	constant GESTURE_SWIPE_RIGHT
#32	constant GESTURE_SWIPE_LEFT
#64	constant GESTURE_SWIPE_UP
#128	constant GESTURE_SWIPE_DOWN
#256	constant GESTURE_PINCH_IN
#512	constant GESTURE_PINCH_OUT
\ enum CameraMode
#0	constant CAMERA_CUSTOM
#1	constant CAMERA_FREE
#2	constant CAMERA_ORBITAL
#3	constant CAMERA_FIRST_PERSON
#4	constant CAMERA_THIRD_PERSON
\ enum CameraProjection
#0	constant CAMERA_PERSPECTIVE
#1	constant CAMERA_ORTHOGRAPHIC
\ enum NPatchLayout
#0	constant NPATCH_NINE_PATCH
#1	constant NPATCH_THREE_PATCH_VERTICAL
#2	constant NPATCH_THREE_PATCH_HORIZONTAL

\ -------===< structs >===--------
\ struct Vector2
begin-structure Vector2
	drop 0 4 +field Vector2-x
	drop 4 4 +field Vector2-y
drop 8 end-structure
\ struct Vector3
begin-structure Vector3
	drop 0 4 +field Vector3-x
	drop 4 4 +field Vector3-y
	drop 8 4 +field Vector3-z
drop 12 end-structure
\ struct Vector4
begin-structure Vector4
	drop 12 4 +field Vector4-w
	drop 0 4 +field Vector4-x
	drop 4 4 +field Vector4-y
	drop 8 4 +field Vector4-z
drop 16 end-structure
\ struct Matrix
begin-structure Matrix
	drop 0 4 +field Matrix-m0
	drop 60 4 +field Matrix-m15
	drop 16 4 +field Matrix-m1
	drop 32 4 +field Matrix-m2
	drop 48 4 +field Matrix-m3
	drop 4 4 +field Matrix-m4
	drop 20 4 +field Matrix-m5
	drop 36 4 +field Matrix-m6
	drop 52 4 +field Matrix-m7
	drop 8 4 +field Matrix-m8
	drop 24 4 +field Matrix-m9
	drop 40 4 +field Matrix-m10
	drop 56 4 +field Matrix-m11
	drop 12 4 +field Matrix-m12
	drop 28 4 +field Matrix-m13
	drop 44 4 +field Matrix-m14
drop 64 end-structure
\ struct Color
begin-structure Color
	drop 2 1 +field Color-b
	drop 0 1 +field Color-r
	drop 1 1 +field Color-g
	drop 3 1 +field Color-a
drop 4 end-structure
\ struct Rectangle
begin-structure Rectangle
	drop 0 4 +field Rectangle-x
	drop 4 4 +field Rectangle-y
	drop 12 4 +field Rectangle-height
	drop 8 4 +field Rectangle-width
drop 16 end-structure
\ struct Image
begin-structure Image
	drop 0 8 +field Image-data
	drop 16 4 +field Image-mipmaps
	drop 12 4 +field Image-height
	drop 8 4 +field Image-width
	drop 20 4 +field Image-format
drop 24 end-structure
\ struct Texture
begin-structure Texture
	drop 0 4 +field Texture-id
	drop 12 4 +field Texture-mipmaps
	drop 8 4 +field Texture-height
	drop 4 4 +field Texture-width
	drop 16 4 +field Texture-format
drop 20 end-structure
\ struct RenderTexture
begin-structure RenderTexture
	drop 0 4 +field RenderTexture-id
	drop 4 20 +field RenderTexture-texture
	drop 24 20 +field RenderTexture-depth
drop 44 end-structure
\ struct NPatchInfo
begin-structure NPatchInfo
	drop 16 4 +field NPatchInfo-left
	drop 0 16 +field NPatchInfo-source
	drop 32 4 +field NPatchInfo-layout
	drop 20 4 +field NPatchInfo-top
	drop 24 4 +field NPatchInfo-right
	drop 28 4 +field NPatchInfo-bottom
drop 36 end-structure
\ struct GlyphInfo
begin-structure GlyphInfo
	drop 4 4 +field GlyphInfo-offsetX
	drop 12 4 +field GlyphInfo-advanceX
	drop 8 4 +field GlyphInfo-offsetY
	drop 0 4 +field GlyphInfo-value
	drop 16 24 +field GlyphInfo-image
drop 40 end-structure
\ struct Font
begin-structure Font
	drop 40 8 +field Font-glyphs
	drop 0 4 +field Font-baseSize
	drop 32 8 +field Font-recs
	drop 4 4 +field Font-glyphCount
	drop 8 4 +field Font-glyphPadding
	drop 12 20 +field Font-texture
drop 48 end-structure
\ struct Camera3D
begin-structure Camera3D
	drop 36 4 +field Camera3D-fovy
	drop 0 12 +field Camera3D-position
	drop 12 12 +field Camera3D-target
	drop 24 12 +field Camera3D-up
	drop 40 4 +field Camera3D-projection
drop 44 end-structure
\ struct Camera2D
begin-structure Camera2D
	drop 20 4 +field Camera2D-zoom
	drop 8 8 +field Camera2D-target
	drop 0 8 +field Camera2D-offset
	drop 16 4 +field Camera2D-rotation
drop 24 end-structure
\ struct Mesh
begin-structure Mesh
	drop 88 8 +field Mesh-animVertices
	drop 8 8 +field Mesh-vertices
	drop 0 4 +field Mesh-vertexCount
	drop 40 8 +field Mesh-tangents
	drop 16 8 +field Mesh-texcoords
	drop 48 8 +field Mesh-colors
	drop 112 8 +field Mesh-vboId
	drop 96 8 +field Mesh-animNormals
	drop 32 8 +field Mesh-normals
	drop 80 8 +field Mesh-boneWeights
	drop 72 8 +field Mesh-boneIndices
	drop 56 8 +field Mesh-indices
	drop 24 8 +field Mesh-texcoords2
	drop 64 4 +field Mesh-boneCount
	drop 4 4 +field Mesh-triangleCount
	drop 104 4 +field Mesh-vaoId
drop 120 end-structure
\ struct Shader
begin-structure Shader
	drop 8 8 +field Shader-locs
	drop 0 4 +field Shader-id
drop 16 end-structure
\ struct MaterialMap
begin-structure MaterialMap
	drop 20 4 +field MaterialMap-color
	drop 24 4 +field MaterialMap-value
	drop 0 20 +field MaterialMap-texture
drop 28 end-structure
\ struct Material
begin-structure Material
	drop 0 16 +field Material-shader
	drop 16 8 +field Material-maps
	drop 24 16 +field Material-params
drop 40 end-structure
\ struct Transform
begin-structure Transform
	drop 0 12 +field Transform-translation
	drop 28 12 +field Transform-scale
	drop 12 16 +field Transform-rotation
drop 40 end-structure
\ struct BoneInfo
begin-structure BoneInfo
	drop 0 32 +field BoneInfo-name
	drop 32 4 +field BoneInfo-parent
drop 36 end-structure
\ struct ModelSkeleton
begin-structure ModelSkeleton
	drop 8 8 +field ModelSkeleton-bones
	drop 16 8 +field ModelSkeleton-bindPose
	drop 0 4 +field ModelSkeleton-boneCount
drop 24 end-structure
\ struct Model
begin-structure Model
	drop 64 4 +field Model-meshCount
	drop 128 8 +field Model-boneMatrices
	drop 68 4 +field Model-materialCount
	drop 80 8 +field Model-materials
	drop 88 8 +field Model-meshMaterial
	drop 120 8 +field Model-currentPose
	drop 0 64 +field Model-transform
	drop 72 8 +field Model-meshes
	drop 96 24 +field Model-skeleton
drop 136 end-structure
\ struct ModelAnimation
begin-structure ModelAnimation
	drop 40 8 +field ModelAnimation-keyframePoses
	drop 0 32 +field ModelAnimation-name
	drop 36 4 +field ModelAnimation-keyframeCount
	drop 32 4 +field ModelAnimation-boneCount
drop 48 end-structure
\ struct Ray
begin-structure Ray
	drop 0 12 +field Ray-position
	drop 12 12 +field Ray-direction
drop 24 end-structure
\ struct RayCollision
begin-structure RayCollision
	drop 4 4 +field RayCollision-distance
	drop 0 1 +field RayCollision-hit
	drop 8 12 +field RayCollision-point
	drop 20 12 +field RayCollision-normal
drop 32 end-structure
\ struct BoundingBox
begin-structure BoundingBox
	drop 12 12 +field BoundingBox-max
	drop 0 12 +field BoundingBox-min
drop 24 end-structure
\ struct Wave
begin-structure Wave
	drop 12 4 +field Wave-channels
	drop 16 8 +field Wave-data
	drop 8 4 +field Wave-sampleSize
	drop 0 4 +field Wave-frameCount
	drop 4 4 +field Wave-sampleRate
drop 24 end-structure
\ struct AudioStream
begin-structure AudioStream
	drop 24 4 +field AudioStream-channels
	drop 0 8 +field AudioStream-buffer
	drop 20 4 +field AudioStream-sampleSize
	drop 16 4 +field AudioStream-sampleRate
	drop 8 8 +field AudioStream-processor
drop 32 end-structure
\ struct Sound
begin-structure Sound
	drop 0 32 +field Sound-stream
	drop 32 4 +field Sound-frameCount
drop 40 end-structure
\ struct Music
begin-structure Music
	drop 0 32 +field Music-stream
	drop 40 4 +field Music-ctxType
	drop 32 4 +field Music-frameCount
	drop 36 1 +field Music-looping
	drop 48 8 +field Music-ctxData
drop 56 end-structure
\ struct VrDeviceInfo
begin-structure VrDeviceInfo
	drop 0 4 +field VrDeviceInfo-hResolution
	drop 4 4 +field VrDeviceInfo-vResolution
	drop 16 4 +field VrDeviceInfo-eyeToScreenDistance
	drop 20 4 +field VrDeviceInfo-lensSeparationDistance
	drop 24 4 +field VrDeviceInfo-interpupillaryDistance
	drop 8 4 +field VrDeviceInfo-hScreenSize
	drop 12 4 +field VrDeviceInfo-vScreenSize
	drop 28 16 +field VrDeviceInfo-lensDistortionValues
	drop 44 16 +field VrDeviceInfo-chromaAbCorrection
drop 60 end-structure
\ struct VrStereoConfig
begin-structure VrStereoConfig
	drop 296 8 +field VrStereoConfig-scaleIn
	drop 128 128 +field VrStereoConfig-viewOffset
	drop 272 8 +field VrStereoConfig-leftScreenCenter
	drop 280 8 +field VrStereoConfig-rightScreenCenter
	drop 256 8 +field VrStereoConfig-leftLensCenter
	drop 264 8 +field VrStereoConfig-rightLensCenter
	drop 288 8 +field VrStereoConfig-scale
	drop 0 128 +field VrStereoConfig-projection
drop 304 end-structure
\ struct FilePathList
begin-structure FilePathList
	drop 0 4 +field FilePathList-count
	drop 8 8 +field FilePathList-paths
drop 16 end-structure
\ struct AutomationEvent
begin-structure AutomationEvent
	drop 0 4 +field AutomationEvent-frame
	drop 4 4 +field AutomationEvent-type
	drop 8 16 +field AutomationEvent-params
drop 24 end-structure
\ struct AutomationEventList
begin-structure AutomationEventList
	drop 4 4 +field AutomationEventList-count
	drop 8 8 +field AutomationEventList-events
	drop 0 4 +field AutomationEventList-capacity
drop 16 end-structure

\ ------===< callbacks >===-------
c-callback LoadFileDataCallback: s a -- a	( fileName dataSize -- )
c-callback SaveFileDataCallback: s a n -- n	( fileName data dataSize -- )
c-callback LoadFileTextCallback: s -- a	( fileName -- )
c-callback SaveFileTextCallback: s s -- n	( fileName text -- )
c-callback AudioCallback: a u -- void	( bufferData frames -- )

\ ------===< functions >===-------
c-function InitWindow InitWindow n n s -- void	( width height title -- )
c-function CloseWindow CloseWindow  -- void	( -- )
c-function WindowShouldClose WindowShouldClose  -- n	( -- )
c-function IsWindowReady IsWindowReady  -- n	( -- )
c-function IsWindowFullscreen IsWindowFullscreen  -- n	( -- )
c-function IsWindowHidden IsWindowHidden  -- n	( -- )
c-function IsWindowMinimized IsWindowMinimized  -- n	( -- )
c-function IsWindowMaximized IsWindowMaximized  -- n	( -- )
c-function IsWindowFocused IsWindowFocused  -- n	( -- )
c-function IsWindowResized IsWindowResized  -- n	( -- )
c-function IsWindowState IsWindowState u -- n	( flag -- )
c-function SetWindowState SetWindowState u -- void	( flags -- )
c-function ClearWindowState ClearWindowState u -- void	( flags -- )
c-function ToggleFullscreen ToggleFullscreen  -- void	( -- )
c-function ToggleBorderlessWindowed ToggleBorderlessWindowed  -- void	( -- )
c-function MaximizeWindow MaximizeWindow  -- void	( -- )
c-function MinimizeWindow MinimizeWindow  -- void	( -- )
c-function RestoreWindow RestoreWindow  -- void	( -- )
c-function SetWindowIcon SetWindowIcon a{*(Image*)} -- void	( image -- )
c-function SetWindowIcons SetWindowIcons a n -- void	( images count -- )
c-function SetWindowTitle SetWindowTitle s -- void	( title -- )
c-function SetWindowPosition SetWindowPosition n n -- void	( x y -- )
c-function SetWindowMonitor SetWindowMonitor n -- void	( monitor -- )
c-function SetWindowMinSize SetWindowMinSize n n -- void	( width height -- )
c-function SetWindowMaxSize SetWindowMaxSize n n -- void	( width height -- )
c-function SetWindowSize SetWindowSize n n -- void	( width height -- )
c-function SetWindowOpacity SetWindowOpacity r -- void	( opacity -- )
c-function SetWindowFocused SetWindowFocused  -- void	( -- )
c-function GetWindowHandle GetWindowHandle  -- a	( -- )
c-function GetScreenWidth GetScreenWidth  -- n	( -- )
c-function GetScreenHeight GetScreenHeight  -- n	( -- )
c-function GetRenderWidth GetRenderWidth  -- n	( -- )
c-function GetRenderHeight GetRenderHeight  -- n	( -- )
c-function GetMonitorCount GetMonitorCount  -- n	( -- )
c-function GetCurrentMonitor GetCurrentMonitor  -- n	( -- )
c-function GetMonitorPosition GetMonitorPosition n -- t{*(Vector2*)}	( monitor -- )
c-function GetMonitorWidth GetMonitorWidth n -- n	( monitor -- )
c-function GetMonitorHeight GetMonitorHeight n -- n	( monitor -- )
c-function GetMonitorPhysicalWidth GetMonitorPhysicalWidth n -- n	( monitor -- )
c-function GetMonitorPhysicalHeight GetMonitorPhysicalHeight n -- n	( monitor -- )
c-function GetMonitorRefreshRate GetMonitorRefreshRate n -- n	( monitor -- )
c-function GetWindowPosition GetWindowPosition  -- t{*(Vector2*)}	( -- )
c-function GetWindowScaleDPI GetWindowScaleDPI  -- t{*(Vector2*)}	( -- )
c-function GetMonitorName GetMonitorName n -- s	( monitor -- )
c-function SetClipboardText SetClipboardText s -- void	( text -- )
c-function GetClipboardText GetClipboardText  -- s	( -- )
c-function GetClipboardImage GetClipboardImage  -- t{*(Image*)}	( -- )
c-function EnableEventWaiting EnableEventWaiting  -- void	( -- )
c-function DisableEventWaiting DisableEventWaiting  -- void	( -- )
c-function ShowCursor ShowCursor  -- void	( -- )
c-function HideCursor HideCursor  -- void	( -- )
c-function IsCursorHidden IsCursorHidden  -- n	( -- )
c-function EnableCursor EnableCursor  -- void	( -- )
c-function DisableCursor DisableCursor  -- void	( -- )
c-function IsCursorOnScreen IsCursorOnScreen  -- n	( -- )
c-function ClearBackground ClearBackground a{*(Color*)} -- void	( color -- )
c-function BeginDrawing BeginDrawing  -- void	( -- )
c-function EndDrawing EndDrawing  -- void	( -- )
c-function BeginMode2D BeginMode2D a{*(Camera2D*)} -- void	( camera -- )
c-function EndMode2D EndMode2D  -- void	( -- )
c-function BeginMode3D BeginMode3D a{*(Camera3D*)} -- void	( camera -- )
c-function EndMode3D EndMode3D  -- void	( -- )
c-function BeginTextureMode BeginTextureMode a{*(RenderTexture*)} -- void	( target -- )
c-function EndTextureMode EndTextureMode  -- void	( -- )
c-function BeginShaderMode BeginShaderMode a{*(Shader*)} -- void	( shader -- )
c-function EndShaderMode EndShaderMode  -- void	( -- )
c-function BeginBlendMode BeginBlendMode n -- void	( mode -- )
c-function EndBlendMode EndBlendMode  -- void	( -- )
c-function BeginScissorMode BeginScissorMode n n n n -- void	( x y width height -- )
c-function EndScissorMode EndScissorMode  -- void	( -- )
c-function BeginVrStereoMode BeginVrStereoMode a{*(VrStereoConfig*)} -- void	( config -- )
c-function EndVrStereoMode EndVrStereoMode  -- void	( -- )
c-function LoadVrStereoConfig LoadVrStereoConfig a{*(VrDeviceInfo*)} -- t{*(VrStereoConfig*)}	( device -- )
c-function UnloadVrStereoConfig UnloadVrStereoConfig a{*(VrStereoConfig*)} -- void	( config -- )
c-function LoadShader LoadShader s s -- t{*(Shader*)}	( vsFileName fsFileName -- )
c-function LoadShaderFromMemory LoadShaderFromMemory s s -- t{*(Shader*)}	( vsCode fsCode -- )
c-function IsShaderValid IsShaderValid a{*(Shader*)} -- n	( shader -- )
c-function GetShaderLocation GetShaderLocation a{*(Shader*)} s -- n	( shader uniformName -- )
c-function GetShaderLocationAttrib GetShaderLocationAttrib a{*(Shader*)} s -- n	( shader attribName -- )
c-function SetShaderValue SetShaderValue a{*(Shader*)} n a n -- void	( shader locIndex value uniformType -- )
c-function SetShaderValueV SetShaderValueV a{*(Shader*)} n a n n -- void	( shader locIndex value uniformType count -- )
c-function SetShaderValueMatrix SetShaderValueMatrix a{*(Shader*)} n a{*(Matrix*)} -- void	( shader locIndex mat -- )
c-function SetShaderValueTexture SetShaderValueTexture a{*(Shader*)} n a{*(Texture*)} -- void	( shader locIndex texture -- )
c-function UnloadShader UnloadShader a{*(Shader*)} -- void	( shader -- )
c-function GetScreenToWorldRay GetScreenToWorldRay a{*(Vector2*)} a{*(Camera3D*)} -- t{*(Ray*)}	( position camera -- )
c-function GetScreenToWorldRayEx GetScreenToWorldRayEx a{*(Vector2*)} a{*(Camera3D*)} n n -- t{*(Ray*)}	( position camera width height -- )
c-function GetWorldToScreen GetWorldToScreen a{*(Vector3*)} a{*(Camera3D*)} -- t{*(Vector2*)}	( position camera -- )
c-function GetWorldToScreenEx GetWorldToScreenEx a{*(Vector3*)} a{*(Camera3D*)} n n -- t{*(Vector2*)}	( position camera width height -- )
c-function GetWorldToScreen2D GetWorldToScreen2D a{*(Vector2*)} a{*(Camera2D*)} -- t{*(Vector2*)}	( position camera -- )
c-function GetScreenToWorld2D GetScreenToWorld2D a{*(Vector2*)} a{*(Camera2D*)} -- t{*(Vector2*)}	( position camera -- )
c-function GetCameraMatrix GetCameraMatrix a{*(Camera3D*)} -- t{*(Matrix*)}	( camera -- )
c-function GetCameraMatrix2D GetCameraMatrix2D a{*(Camera2D*)} -- t{*(Matrix*)}	( camera -- )
c-function SetTargetFPS SetTargetFPS n -- void	( fps -- )
c-function GetFrameTime GetFrameTime  -- r	( -- )
c-function GetTime GetTime  -- r	( -- )
c-function GetFPS GetFPS  -- n	( -- )
c-function SwapScreenBuffer SwapScreenBuffer  -- void	( -- )
c-function PollInputEvents PollInputEvents  -- void	( -- )
c-function WaitTime WaitTime r -- void	( seconds -- )
c-function SetRandomSeed SetRandomSeed u -- void	( seed -- )
c-function GetRandomValue GetRandomValue n n -- n	( min max -- )
c-function LoadRandomSequence LoadRandomSequence u n n -- a	( count min max -- )
c-function UnloadRandomSequence UnloadRandomSequence a -- void	( sequence -- )
c-function TakeScreenshot TakeScreenshot s -- void	( fileName -- )
c-function SetConfigFlags SetConfigFlags u -- void	( flags -- )
c-function OpenURL OpenURL s -- void	( url -- )
c-function SetTraceLogLevel SetTraceLogLevel n -- void	( logLevel -- )
c-function TraceLog TraceLog n s ... -- void	( logLevel text <noname> -- )
c-function SetTraceLogCallback SetTraceLogCallback a -- void	( callback -- )
c-function MemAlloc MemAlloc u -- a	( size -- )
c-function MemRealloc MemRealloc a u -- a	( ptr size -- )
c-function MemFree MemFree a -- void	( ptr -- )
c-function LoadFileData LoadFileData s a -- a	( fileName dataSize -- )
c-function UnloadFileData UnloadFileData a -- void	( data -- )
c-function SaveFileData SaveFileData s a n -- n	( fileName data dataSize -- )
c-function ExportDataAsCode ExportDataAsCode a n s -- n	( data dataSize fileName -- )
c-function LoadFileText LoadFileText s -- a	( fileName -- )
c-function UnloadFileText UnloadFileText a -- void	( text -- )
c-function SaveFileText SaveFileText s s -- n	( fileName text -- )
c-function SetLoadFileDataCallback SetLoadFileDataCallback a -- void	( callback -- )
c-function SetSaveFileDataCallback SetSaveFileDataCallback a -- void	( callback -- )
c-function SetLoadFileTextCallback SetLoadFileTextCallback a -- void	( callback -- )
c-function SetSaveFileTextCallback SetSaveFileTextCallback a -- void	( callback -- )
c-function FileRename FileRename s s -- n	( fileName fileRename -- )
c-function FileRemove FileRemove s -- n	( fileName -- )
c-function FileCopy FileCopy s s -- n	( srcPath dstPath -- )
c-function FileMove FileMove s s -- n	( srcPath dstPath -- )
c-function FileTextReplace FileTextReplace s s s -- n	( fileName search replacement -- )
c-function FileTextFindIndex FileTextFindIndex s s -- n	( fileName search -- )
c-function FileExists FileExists s -- n	( fileName -- )
c-function DirectoryExists DirectoryExists s -- n	( dirPath -- )
c-function IsFileExtension IsFileExtension s s -- n	( fileName ext -- )
c-function GetFileLength GetFileLength s -- n	( fileName -- )
c-function GetFileModTime GetFileModTime s -- n	( fileName -- )
c-function GetFileExtension GetFileExtension s -- s	( fileName -- )
c-function GetFileName GetFileName s -- s	( filePath -- )
c-function GetFileNameWithoutExt GetFileNameWithoutExt s -- s	( filePath -- )
c-function GetDirectoryPath GetDirectoryPath s -- s	( filePath -- )
c-function GetPrevDirectoryPath GetPrevDirectoryPath s -- s	( dirPath -- )
c-function GetWorkingDirectory GetWorkingDirectory  -- s	( -- )
c-function GetApplicationDirectory GetApplicationDirectory  -- s	( -- )
c-function MakeDirectory MakeDirectory s -- n	( dirPath -- )
c-function ChangeDirectory ChangeDirectory s -- n	( dirPath -- )
c-function IsPathFile IsPathFile s -- n	( path -- )
c-function IsFileNameValid IsFileNameValid s -- n	( fileName -- )
c-function LoadDirectoryFiles LoadDirectoryFiles s -- t{*(FilePathList*)}	( dirPath -- )
c-function LoadDirectoryFilesEx LoadDirectoryFilesEx s s n -- t{*(FilePathList*)}	( basePath filter scanSubdirs -- )
c-function UnloadDirectoryFiles UnloadDirectoryFiles a{*(FilePathList*)} -- void	( files -- )
c-function IsFileDropped IsFileDropped  -- n	( -- )
c-function LoadDroppedFiles LoadDroppedFiles  -- t{*(FilePathList*)}	( -- )
c-function UnloadDroppedFiles UnloadDroppedFiles a{*(FilePathList*)} -- void	( files -- )
c-function GetDirectoryFileCount GetDirectoryFileCount s -- u	( dirPath -- )
c-function GetDirectoryFileCountEx GetDirectoryFileCountEx s s n -- u	( basePath filter scanSubdirs -- )
c-function CompressData CompressData a n a -- a	( data dataSize compDataSize -- )
c-function DecompressData DecompressData a n a -- a	( compData compDataSize dataSize -- )
c-function EncodeDataBase64 EncodeDataBase64 a n a -- a	( data dataSize outputSize -- )
c-function DecodeDataBase64 DecodeDataBase64 s a -- a	( text outputSize -- )
c-function ComputeCRC32 ComputeCRC32 a n -- u	( data dataSize -- )
c-function ComputeMD5 ComputeMD5 a n -- a	( data dataSize -- )
c-function ComputeSHA1 ComputeSHA1 a n -- a	( data dataSize -- )
c-function ComputeSHA256 ComputeSHA256 a n -- a	( data dataSize -- )
c-function LoadAutomationEventList LoadAutomationEventList s -- t{*(AutomationEventList*)}	( fileName -- )
c-function UnloadAutomationEventList UnloadAutomationEventList a{*(AutomationEventList*)} -- void	( list -- )
c-function ExportAutomationEventList ExportAutomationEventList a{*(AutomationEventList*)} s -- n	( list fileName -- )
c-function SetAutomationEventList SetAutomationEventList a -- void	( list -- )
c-function SetAutomationEventBaseFrame SetAutomationEventBaseFrame n -- void	( frame -- )
c-function StartAutomationEventRecording StartAutomationEventRecording  -- void	( -- )
c-function StopAutomationEventRecording StopAutomationEventRecording  -- void	( -- )
c-function PlayAutomationEvent PlayAutomationEvent a{*(AutomationEvent*)} -- void	( event -- )
c-function IsKeyPressed IsKeyPressed n -- n	( key -- )
c-function IsKeyPressedRepeat IsKeyPressedRepeat n -- n	( key -- )
c-function IsKeyDown IsKeyDown n -- n	( key -- )
c-function IsKeyReleased IsKeyReleased n -- n	( key -- )
c-function IsKeyUp IsKeyUp n -- n	( key -- )
c-function GetKeyPressed GetKeyPressed  -- n	( -- )
c-function GetCharPressed GetCharPressed  -- n	( -- )
c-function GetKeyName GetKeyName n -- s	( key -- )
c-function SetExitKey SetExitKey n -- void	( key -- )
c-function IsGamepadAvailable IsGamepadAvailable n -- n	( gamepad -- )
c-function GetGamepadName GetGamepadName n -- s	( gamepad -- )
c-function IsGamepadButtonPressed IsGamepadButtonPressed n n -- n	( gamepad button -- )
c-function IsGamepadButtonDown IsGamepadButtonDown n n -- n	( gamepad button -- )
c-function IsGamepadButtonReleased IsGamepadButtonReleased n n -- n	( gamepad button -- )
c-function IsGamepadButtonUp IsGamepadButtonUp n n -- n	( gamepad button -- )
c-function GetGamepadButtonPressed GetGamepadButtonPressed  -- n	( -- )
c-function GetGamepadAxisCount GetGamepadAxisCount n -- n	( gamepad -- )
c-function GetGamepadAxisMovement GetGamepadAxisMovement n n -- r	( gamepad axis -- )
c-function SetGamepadMappings SetGamepadMappings s -- n	( mappings -- )
c-function SetGamepadVibration SetGamepadVibration n r r r -- void	( gamepad leftMotor rightMotor duration -- )
c-function IsMouseButtonPressed IsMouseButtonPressed n -- n	( button -- )
c-function IsMouseButtonDown IsMouseButtonDown n -- n	( button -- )
c-function IsMouseButtonReleased IsMouseButtonReleased n -- n	( button -- )
c-function IsMouseButtonUp IsMouseButtonUp n -- n	( button -- )
c-function GetMouseX GetMouseX  -- n	( -- )
c-function GetMouseY GetMouseY  -- n	( -- )
c-function GetMousePosition GetMousePosition  -- t{*(Vector2*)}	( -- )
c-function GetMouseDelta GetMouseDelta  -- t{*(Vector2*)}	( -- )
c-function SetMousePosition SetMousePosition n n -- void	( x y -- )
c-function SetMouseOffset SetMouseOffset n n -- void	( offsetX offsetY -- )
c-function SetMouseScale SetMouseScale r r -- void	( scaleX scaleY -- )
c-function GetMouseWheelMove GetMouseWheelMove  -- r	( -- )
c-function GetMouseWheelMoveV GetMouseWheelMoveV  -- t{*(Vector2*)}	( -- )
c-function SetMouseCursor SetMouseCursor n -- void	( cursor -- )
c-function GetTouchX GetTouchX  -- n	( -- )
c-function GetTouchY GetTouchY  -- n	( -- )
c-function GetTouchPosition GetTouchPosition n -- t{*(Vector2*)}	( index -- )
c-function GetTouchPointId GetTouchPointId n -- n	( index -- )
c-function GetTouchPointCount GetTouchPointCount  -- n	( -- )
c-function SetGesturesEnabled SetGesturesEnabled u -- void	( flags -- )
c-function IsGestureDetected IsGestureDetected u -- n	( gesture -- )
c-function GetGestureDetected GetGestureDetected  -- n	( -- )
c-function GetGestureHoldDuration GetGestureHoldDuration  -- r	( -- )
c-function GetGestureDragVector GetGestureDragVector  -- t{*(Vector2*)}	( -- )
c-function GetGestureDragAngle GetGestureDragAngle  -- r	( -- )
c-function GetGesturePinchVector GetGesturePinchVector  -- t{*(Vector2*)}	( -- )
c-function GetGesturePinchAngle GetGesturePinchAngle  -- r	( -- )
c-function UpdateCamera UpdateCamera a n -- void	( camera mode -- )
c-function UpdateCameraPro UpdateCameraPro a a{*(Vector3*)} a{*(Vector3*)} r -- void	( camera movement rotation zoom -- )
c-function SetShapesTexture SetShapesTexture a{*(Texture*)} a{*(Rectangle*)} -- void	( texture source -- )
c-function GetShapesTexture GetShapesTexture  -- t{*(Texture*)}	( -- )
c-function GetShapesTextureRectangle GetShapesTextureRectangle  -- t{*(Rectangle*)}	( -- )
c-function DrawPixel DrawPixel n n a{*(Color*)} -- void	( posX posY color -- )
c-function DrawPixelV DrawPixelV a{*(Vector2*)} a{*(Color*)} -- void	( position color -- )
c-function DrawLine DrawLine n n n n a{*(Color*)} -- void	( startPosX startPosY endPosX endPosY color -- )
c-function DrawLineV DrawLineV a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( startPos endPos color -- )
c-function DrawLineEx DrawLineEx a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( startPos endPos thick color -- )
c-function DrawLineStrip DrawLineStrip a n a{*(Color*)} -- void	( points pointCount color -- )
c-function DrawLineBezier DrawLineBezier a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( startPos endPos thick color -- )
c-function DrawLineDashed DrawLineDashed a{*(Vector2*)} a{*(Vector2*)} n n a{*(Color*)} -- void	( startPos endPos dashSize spaceSize color -- )
c-function DrawCircle DrawCircle n n r a{*(Color*)} -- void	( centerX centerY radius color -- )
c-function DrawCircleV DrawCircleV a{*(Vector2*)} r a{*(Color*)} -- void	( center radius color -- )
c-function DrawCircleGradient DrawCircleGradient a{*(Vector2*)} r a{*(Color*)} a{*(Color*)} -- void	( center radius inner outer -- )
c-function DrawCircleSector DrawCircleSector a{*(Vector2*)} r r r n a{*(Color*)} -- void	( center radius startAngle endAngle segments color -- )
c-function DrawCircleSectorLines DrawCircleSectorLines a{*(Vector2*)} r r r n a{*(Color*)} -- void	( center radius startAngle endAngle segments color -- )
c-function DrawCircleLines DrawCircleLines n n r a{*(Color*)} -- void	( centerX centerY radius color -- )
c-function DrawCircleLinesV DrawCircleLinesV a{*(Vector2*)} r a{*(Color*)} -- void	( center radius color -- )
c-function DrawEllipse DrawEllipse n n r r a{*(Color*)} -- void	( centerX centerY radiusH radiusV color -- )
c-function DrawEllipseV DrawEllipseV a{*(Vector2*)} r r a{*(Color*)} -- void	( center radiusH radiusV color -- )
c-function DrawEllipseLines DrawEllipseLines n n r r a{*(Color*)} -- void	( centerX centerY radiusH radiusV color -- )
c-function DrawEllipseLinesV DrawEllipseLinesV a{*(Vector2*)} r r a{*(Color*)} -- void	( center radiusH radiusV color -- )
c-function DrawRing DrawRing a{*(Vector2*)} r r r r n a{*(Color*)} -- void	( center innerRadius outerRadius startAngle endAngle segments color -- )
c-function DrawRingLines DrawRingLines a{*(Vector2*)} r r r r n a{*(Color*)} -- void	( center innerRadius outerRadius startAngle endAngle segments color -- )
c-function DrawRectangle DrawRectangle n n n n a{*(Color*)} -- void	( posX posY width height color -- )
c-function DrawRectangleV DrawRectangleV a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawRectangleRec DrawRectangleRec a{*(Rectangle*)} a{*(Color*)} -- void	( rec color -- )
c-function DrawRectanglePro DrawRectanglePro a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( rec origin rotation color -- )
c-function DrawRectangleGradientV DrawRectangleGradientV n n n n a{*(Color*)} a{*(Color*)} -- void	( posX posY width height top bottom -- )
c-function DrawRectangleGradientH DrawRectangleGradientH n n n n a{*(Color*)} a{*(Color*)} -- void	( posX posY width height left right -- )
c-function DrawRectangleGradientEx DrawRectangleGradientEx a{*(Rectangle*)} a{*(Color*)} a{*(Color*)} a{*(Color*)} a{*(Color*)} -- void	( rec topLeft bottomLeft bottomRight topRight -- )
c-function DrawRectangleLines DrawRectangleLines n n n n a{*(Color*)} -- void	( posX posY width height color -- )
c-function DrawRectangleLinesEx DrawRectangleLinesEx a{*(Rectangle*)} r a{*(Color*)} -- void	( rec lineThick color -- )
c-function DrawRectangleRounded DrawRectangleRounded a{*(Rectangle*)} r n a{*(Color*)} -- void	( rec roundness segments color -- )
c-function DrawRectangleRoundedLines DrawRectangleRoundedLines a{*(Rectangle*)} r n a{*(Color*)} -- void	( rec roundness segments color -- )
c-function DrawRectangleRoundedLinesEx DrawRectangleRoundedLinesEx a{*(Rectangle*)} r n r a{*(Color*)} -- void	( rec roundness segments lineThick color -- )
c-function DrawTriangle DrawTriangle a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleLines DrawTriangleLines a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleFan DrawTriangleFan a n a{*(Color*)} -- void	( points pointCount color -- )
c-function DrawTriangleStrip DrawTriangleStrip a n a{*(Color*)} -- void	( points pointCount color -- )
c-function DrawPoly DrawPoly a{*(Vector2*)} n r r a{*(Color*)} -- void	( center sides radius rotation color -- )
c-function DrawPolyLines DrawPolyLines a{*(Vector2*)} n r r a{*(Color*)} -- void	( center sides radius rotation color -- )
c-function DrawPolyLinesEx DrawPolyLinesEx a{*(Vector2*)} n r r r a{*(Color*)} -- void	( center sides radius rotation lineThick color -- )
c-function DrawSplineLinear DrawSplineLinear a n r a{*(Color*)} -- void	( points pointCount thick color -- )
c-function DrawSplineBasis DrawSplineBasis a n r a{*(Color*)} -- void	( points pointCount thick color -- )
c-function DrawSplineCatmullRom DrawSplineCatmullRom a n r a{*(Color*)} -- void	( points pointCount thick color -- )
c-function DrawSplineBezierQuadratic DrawSplineBezierQuadratic a n r a{*(Color*)} -- void	( points pointCount thick color -- )
c-function DrawSplineBezierCubic DrawSplineBezierCubic a n r a{*(Color*)} -- void	( points pointCount thick color -- )
c-function DrawSplineSegmentLinear DrawSplineSegmentLinear a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( p1 p2 thick color -- )
c-function DrawSplineSegmentBasis DrawSplineSegmentBasis a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( p1 p2 p3 p4 thick color -- )
c-function DrawSplineSegmentCatmullRom DrawSplineSegmentCatmullRom a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( p1 p2 p3 p4 thick color -- )
c-function DrawSplineSegmentBezierQuadratic DrawSplineSegmentBezierQuadratic a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( p1 c2 p3 thick color -- )
c-function DrawSplineSegmentBezierCubic DrawSplineSegmentBezierCubic a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( p1 c2 c3 p4 thick color -- )
c-function GetSplinePointLinear GetSplinePointLinear a{*(Vector2*)} a{*(Vector2*)} r -- t{*(Vector2*)}	( startPos endPos t -- )
c-function GetSplinePointBasis GetSplinePointBasis a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r -- t{*(Vector2*)}	( p1 p2 p3 p4 t -- )
c-function GetSplinePointCatmullRom GetSplinePointCatmullRom a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r -- t{*(Vector2*)}	( p1 p2 p3 p4 t -- )
c-function GetSplinePointBezierQuad GetSplinePointBezierQuad a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r -- t{*(Vector2*)}	( p1 c2 p3 t -- )
c-function GetSplinePointBezierCubic GetSplinePointBezierCubic a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} r -- t{*(Vector2*)}	( p1 c2 c3 p4 t -- )
c-function CheckCollisionRecs CheckCollisionRecs a{*(Rectangle*)} a{*(Rectangle*)} -- n	( rec1 rec2 -- )
c-function CheckCollisionCircles CheckCollisionCircles a{*(Vector2*)} r a{*(Vector2*)} r -- n	( center1 radius1 center2 radius2 -- )
c-function CheckCollisionCircleRec CheckCollisionCircleRec a{*(Vector2*)} r a{*(Rectangle*)} -- n	( center radius rec -- )
c-function CheckCollisionCircleLine CheckCollisionCircleLine a{*(Vector2*)} r a{*(Vector2*)} a{*(Vector2*)} -- n	( center radius p1 p2 -- )
c-function CheckCollisionPointRec CheckCollisionPointRec a{*(Vector2*)} a{*(Rectangle*)} -- n	( point rec -- )
c-function CheckCollisionPointCircle CheckCollisionPointCircle a{*(Vector2*)} a{*(Vector2*)} r -- n	( point center radius -- )
c-function CheckCollisionPointTriangle CheckCollisionPointTriangle a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} -- n	( point p1 p2 p3 -- )
c-function CheckCollisionPointLine CheckCollisionPointLine a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} n -- n	( point p1 p2 threshold -- )
c-function CheckCollisionPointPoly CheckCollisionPointPoly a{*(Vector2*)} a n -- n	( point points pointCount -- )
c-function CheckCollisionLines CheckCollisionLines a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a -- n	( startPos1 endPos1 startPos2 endPos2 collisionPoint -- )
c-function GetCollisionRec GetCollisionRec a{*(Rectangle*)} a{*(Rectangle*)} -- t{*(Rectangle*)}	( rec1 rec2 -- )
c-function LoadImage LoadImage s -- t{*(Image*)}	( fileName -- )
c-function LoadImageRaw LoadImageRaw s n n n n -- t{*(Image*)}	( fileName width height format headerSize -- )
c-function LoadImageAnim LoadImageAnim s a -- t{*(Image*)}	( fileName frames -- )
c-function LoadImageAnimFromMemory LoadImageAnimFromMemory s a n a -- t{*(Image*)}	( fileType fileData dataSize frames -- )
c-function LoadImageFromMemory LoadImageFromMemory s a n -- t{*(Image*)}	( fileType fileData dataSize -- )
c-function LoadImageFromTexture LoadImageFromTexture a{*(Texture*)} -- t{*(Image*)}	( texture -- )
c-function LoadImageFromScreen LoadImageFromScreen  -- t{*(Image*)}	( -- )
c-function IsImageValid IsImageValid a{*(Image*)} -- n	( image -- )
c-function UnloadImage UnloadImage a{*(Image*)} -- void	( image -- )
c-function ExportImage ExportImage a{*(Image*)} s -- n	( image fileName -- )
c-function ExportImageToMemory ExportImageToMemory a{*(Image*)} s a -- a	( image fileType fileSize -- )
c-function ExportImageAsCode ExportImageAsCode a{*(Image*)} s -- n	( image fileName -- )
c-function GenImageColor GenImageColor n n a{*(Color*)} -- t{*(Image*)}	( width height color -- )
c-function GenImageGradientLinear GenImageGradientLinear n n n a{*(Color*)} a{*(Color*)} -- t{*(Image*)}	( width height direction start end -- )
c-function GenImageGradientRadial GenImageGradientRadial n n r a{*(Color*)} a{*(Color*)} -- t{*(Image*)}	( width height density inner outer -- )
c-function GenImageGradientSquare GenImageGradientSquare n n r a{*(Color*)} a{*(Color*)} -- t{*(Image*)}	( width height density inner outer -- )
c-function GenImageChecked GenImageChecked n n n n a{*(Color*)} a{*(Color*)} -- t{*(Image*)}	( width height checksX checksY col1 col2 -- )
c-function GenImageWhiteNoise GenImageWhiteNoise n n r -- t{*(Image*)}	( width height factor -- )
c-function GenImagePerlinNoise GenImagePerlinNoise n n n n r -- t{*(Image*)}	( width height offsetX offsetY scale -- )
c-function GenImageCellular GenImageCellular n n n -- t{*(Image*)}	( width height tileSize -- )
c-function GenImageText GenImageText n n s -- t{*(Image*)}	( width height text -- )
c-function ImageCopy ImageCopy a{*(Image*)} -- t{*(Image*)}	( image -- )
c-function ImageFromImage ImageFromImage a{*(Image*)} a{*(Rectangle*)} -- t{*(Image*)}	( image rec -- )
c-function ImageFromChannel ImageFromChannel a{*(Image*)} n -- t{*(Image*)}	( image selectedChannel -- )
c-function ImageText ImageText s n a{*(Color*)} -- t{*(Image*)}	( text fontSize color -- )
c-function ImageTextEx ImageTextEx a{*(Font*)} s r r a{*(Color*)} -- t{*(Image*)}	( font text fontSize spacing tint -- )
c-function ImageFormat ImageFormat a n -- void	( image newFormat -- )
c-function ImageToPOT ImageToPOT a a{*(Color*)} -- void	( image fill -- )
c-function ImageCrop ImageCrop a a{*(Rectangle*)} -- void	( image crop -- )
c-function ImageAlphaCrop ImageAlphaCrop a r -- void	( image threshold -- )
c-function ImageAlphaClear ImageAlphaClear a a{*(Color*)} r -- void	( image color threshold -- )
c-function ImageAlphaMask ImageAlphaMask a a{*(Image*)} -- void	( image alphaMask -- )
c-function ImageAlphaPremultiply ImageAlphaPremultiply a -- void	( image -- )
c-function ImageBlurGaussian ImageBlurGaussian a n -- void	( image blurSize -- )
c-function ImageKernelConvolution ImageKernelConvolution a a n -- void	( image kernel kernelSize -- )
c-function ImageResize ImageResize a n n -- void	( image newWidth newHeight -- )
c-function ImageResizeNN ImageResizeNN a n n -- void	( image newWidth newHeight -- )
c-function ImageResizeCanvas ImageResizeCanvas a n n n n a{*(Color*)} -- void	( image newWidth newHeight offsetX offsetY fill -- )
c-function ImageMipmaps ImageMipmaps a -- void	( image -- )
c-function ImageDither ImageDither a n n n n -- void	( image rBpp gBpp bBpp aBpp -- )
c-function ImageFlipVertical ImageFlipVertical a -- void	( image -- )
c-function ImageFlipHorizontal ImageFlipHorizontal a -- void	( image -- )
c-function ImageRotate ImageRotate a n -- void	( image degrees -- )
c-function ImageRotateCW ImageRotateCW a -- void	( image -- )
c-function ImageRotateCCW ImageRotateCCW a -- void	( image -- )
c-function ImageColorTint ImageColorTint a a{*(Color*)} -- void	( image color -- )
c-function ImageColorInvert ImageColorInvert a -- void	( image -- )
c-function ImageColorGrayscale ImageColorGrayscale a -- void	( image -- )
c-function ImageColorContrast ImageColorContrast a r -- void	( image contrast -- )
c-function ImageColorBrightness ImageColorBrightness a n -- void	( image brightness -- )
c-function ImageColorReplace ImageColorReplace a a{*(Color*)} a{*(Color*)} -- void	( image color replace -- )
c-function LoadImageColors LoadImageColors a{*(Image*)} -- a	( image -- )
c-function LoadImagePalette LoadImagePalette a{*(Image*)} n a -- a	( image maxPaletteSize colorCount -- )
c-function UnloadImageColors UnloadImageColors a -- void	( colors -- )
c-function UnloadImagePalette UnloadImagePalette a -- void	( colors -- )
c-function GetImageAlphaBorder GetImageAlphaBorder a{*(Image*)} r -- t{*(Rectangle*)}	( image threshold -- )
c-function GetImageColor GetImageColor a{*(Image*)} n n -- t{*(Color*)}	( image x y -- )
c-function ImageClearBackground ImageClearBackground a a{*(Color*)} -- void	( dst color -- )
c-function ImageDrawPixel ImageDrawPixel a n n a{*(Color*)} -- void	( dst posX posY color -- )
c-function ImageDrawPixelV ImageDrawPixelV a a{*(Vector2*)} a{*(Color*)} -- void	( dst position color -- )
c-function ImageDrawLine ImageDrawLine a n n n n a{*(Color*)} -- void	( dst startPosX startPosY endPosX endPosY color -- )
c-function ImageDrawLineV ImageDrawLineV a a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst start end color -- )
c-function ImageDrawLineEx ImageDrawLineEx a a{*(Vector2*)} a{*(Vector2*)} n a{*(Color*)} -- void	( dst start end thick color -- )
c-function ImageDrawCircle ImageDrawCircle a n n n a{*(Color*)} -- void	( dst centerX centerY radius color -- )
c-function ImageDrawCircleV ImageDrawCircleV a a{*(Vector2*)} n a{*(Color*)} -- void	( dst center radius color -- )
c-function ImageDrawCircleLines ImageDrawCircleLines a n n n a{*(Color*)} -- void	( dst centerX centerY radius color -- )
c-function ImageDrawCircleLinesV ImageDrawCircleLinesV a a{*(Vector2*)} n a{*(Color*)} -- void	( dst center radius color -- )
c-function ImageDrawRectangle ImageDrawRectangle a n n n n a{*(Color*)} -- void	( dst posX posY width height color -- )
c-function ImageDrawRectangleV ImageDrawRectangleV a a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst position size color -- )
c-function ImageDrawRectangleRec ImageDrawRectangleRec a a{*(Rectangle*)} a{*(Color*)} -- void	( dst rec color -- )
c-function ImageDrawRectangleLines ImageDrawRectangleLines a a{*(Rectangle*)} n a{*(Color*)} -- void	( dst rec thick color -- )
c-function ImageDrawTriangle ImageDrawTriangle a a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst v1 v2 v3 color -- )
c-function ImageDrawTriangleEx ImageDrawTriangleEx a a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} a{*(Color*)} a{*(Color*)} -- void	( dst v1 v2 v3 c1 c2 c3 -- )
c-function ImageDrawTriangleLines ImageDrawTriangleLines a a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst v1 v2 v3 color -- )
c-function ImageDrawTriangleFan ImageDrawTriangleFan a a n a{*(Color*)} -- void	( dst points pointCount color -- )
c-function ImageDrawTriangleStrip ImageDrawTriangleStrip a a n a{*(Color*)} -- void	( dst points pointCount color -- )
c-function ImageDraw ImageDraw a a{*(Image*)} a{*(Rectangle*)} a{*(Rectangle*)} a{*(Color*)} -- void	( dst src srcRec dstRec tint -- )
c-function ImageDrawText ImageDrawText a s n n n a{*(Color*)} -- void	( dst text posX posY fontSize color -- )
c-function ImageDrawTextEx ImageDrawTextEx a a{*(Font*)} s a{*(Vector2*)} r r a{*(Color*)} -- void	( dst font text position fontSize spacing tint -- )
c-function LoadTexture LoadTexture s -- t{*(Texture*)}	( fileName -- )
c-function LoadTextureFromImage LoadTextureFromImage a{*(Image*)} -- t{*(Texture*)}	( image -- )
c-function LoadTextureCubemap LoadTextureCubemap a{*(Image*)} n -- t{*(Texture*)}	( image layout -- )
c-function LoadRenderTexture LoadRenderTexture n n -- t{*(RenderTexture*)}	( width height -- )
c-function IsTextureValid IsTextureValid a{*(Texture*)} -- n	( texture -- )
c-function UnloadTexture UnloadTexture a{*(Texture*)} -- void	( texture -- )
c-function IsRenderTextureValid IsRenderTextureValid a{*(RenderTexture*)} -- n	( target -- )
c-function UnloadRenderTexture UnloadRenderTexture a{*(RenderTexture*)} -- void	( target -- )
c-function UpdateTexture UpdateTexture a{*(Texture*)} a -- void	( texture pixels -- )
c-function UpdateTextureRec UpdateTextureRec a{*(Texture*)} a{*(Rectangle*)} a -- void	( texture rec pixels -- )
c-function GenTextureMipmaps GenTextureMipmaps a -- void	( texture -- )
c-function SetTextureFilter SetTextureFilter a{*(Texture*)} n -- void	( texture filter -- )
c-function SetTextureWrap SetTextureWrap a{*(Texture*)} n -- void	( texture wrap -- )
c-function DrawTexture DrawTexture a{*(Texture*)} n n a{*(Color*)} -- void	( texture posX posY tint -- )
c-function DrawTextureV DrawTextureV a{*(Texture*)} a{*(Vector2*)} a{*(Color*)} -- void	( texture position tint -- )
c-function DrawTextureEx DrawTextureEx a{*(Texture*)} a{*(Vector2*)} r r a{*(Color*)} -- void	( texture position rotation scale tint -- )
c-function DrawTextureRec DrawTextureRec a{*(Texture*)} a{*(Rectangle*)} a{*(Vector2*)} a{*(Color*)} -- void	( texture source position tint -- )
c-function DrawTexturePro DrawTexturePro a{*(Texture*)} a{*(Rectangle*)} a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( texture source dest origin rotation tint -- )
c-function DrawTextureNPatch DrawTextureNPatch a{*(Texture*)} a{*(NPatchInfo*)} a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( texture nPatchInfo dest origin rotation tint -- )
c-function ColorIsEqual ColorIsEqual a{*(Color*)} a{*(Color*)} -- n	( col1 col2 -- )
c-function Fade Fade a{*(Color*)} r -- t{*(Color*)}	( color alpha -- )
c-function ColorToInt ColorToInt a{*(Color*)} -- n	( color -- )
c-function ColorNormalize ColorNormalize a{*(Color*)} -- t{*(Vector4*)}	( color -- )
c-function ColorFromNormalized ColorFromNormalized a{*(Vector4*)} -- t{*(Color*)}	( normalized -- )
c-function ColorToHSV ColorToHSV a{*(Color*)} -- t{*(Vector3*)}	( color -- )
c-function ColorFromHSV ColorFromHSV r r r -- t{*(Color*)}	( hue saturation value -- )
c-function ColorTint ColorTint a{*(Color*)} a{*(Color*)} -- t{*(Color*)}	( color tint -- )
c-function ColorBrightness ColorBrightness a{*(Color*)} r -- t{*(Color*)}	( color factor -- )
c-function ColorContrast ColorContrast a{*(Color*)} r -- t{*(Color*)}	( color contrast -- )
c-function ColorAlpha ColorAlpha a{*(Color*)} r -- t{*(Color*)}	( color alpha -- )
c-function ColorAlphaBlend ColorAlphaBlend a{*(Color*)} a{*(Color*)} a{*(Color*)} -- t{*(Color*)}	( dst src tint -- )
c-function ColorLerp ColorLerp a{*(Color*)} a{*(Color*)} r -- t{*(Color*)}	( color1 color2 factor -- )
c-function GetColor GetColor u -- t{*(Color*)}	( hexValue -- )
c-function GetPixelColor GetPixelColor a n -- t{*(Color*)}	( srcPtr format -- )
c-function SetPixelColor SetPixelColor a a{*(Color*)} n -- void	( dstPtr color format -- )
c-function GetPixelDataSize GetPixelDataSize n n n -- n	( width height format -- )
c-function GetFontDefault GetFontDefault  -- t{*(Font*)}	( -- )
c-function LoadFont LoadFont s -- t{*(Font*)}	( fileName -- )
c-function LoadFontEx LoadFontEx s n a n -- t{*(Font*)}	( fileName fontSize codepoints codepointCount -- )
c-function LoadFontFromImage LoadFontFromImage a{*(Image*)} a{*(Color*)} n -- t{*(Font*)}	( image key firstChar -- )
c-function LoadFontFromMemory LoadFontFromMemory s a n n a n -- t{*(Font*)}	( fileType fileData dataSize fontSize codepoints codepointCount -- )
c-function IsFontValid IsFontValid a{*(Font*)} -- n	( font -- )
c-function LoadFontData LoadFontData a n n a n n a -- a	( fileData dataSize fontSize codepoints codepointCount type glyphCount -- )
c-function GenImageFontAtlas GenImageFontAtlas a a n n n n -- t{*(Image*)}	( glyphs glyphRecs glyphCount fontSize padding packMethod -- )
c-function UnloadFontData UnloadFontData a n -- void	( glyphs glyphCount -- )
c-function UnloadFont UnloadFont a{*(Font*)} -- void	( font -- )
c-function ExportFontAsCode ExportFontAsCode a{*(Font*)} s -- n	( font fileName -- )
c-function DrawFPS DrawFPS n n -- void	( posX posY -- )
c-function DrawText DrawText s n n n a{*(Color*)} -- void	( text posX posY fontSize color -- )
c-function DrawTextEx DrawTextEx a{*(Font*)} s a{*(Vector2*)} r r a{*(Color*)} -- void	( font text position fontSize spacing tint -- )
c-function DrawTextPro DrawTextPro a{*(Font*)} s a{*(Vector2*)} a{*(Vector2*)} r r r a{*(Color*)} -- void	( font text position origin rotation fontSize spacing tint -- )
c-function DrawTextCodepoint DrawTextCodepoint a{*(Font*)} n a{*(Vector2*)} r a{*(Color*)} -- void	( font codepoint position fontSize tint -- )
c-function DrawTextCodepoints DrawTextCodepoints a{*(Font*)} a n a{*(Vector2*)} r r a{*(Color*)} -- void	( font codepoints codepointCount position fontSize spacing tint -- )
c-function SetTextLineSpacing SetTextLineSpacing n -- void	( spacing -- )
c-function MeasureText MeasureText s n -- n	( text fontSize -- )
c-function MeasureTextEx MeasureTextEx a{*(Font*)} s r r -- t{*(Vector2*)}	( font text fontSize spacing -- )
c-function MeasureTextCodepoints MeasureTextCodepoints a{*(Font*)} a n r r -- t{*(Vector2*)}	( font codepoints length fontSize spacing -- )
c-function GetGlyphIndex GetGlyphIndex a{*(Font*)} n -- n	( font codepoint -- )
c-function GetGlyphInfo GetGlyphInfo a{*(Font*)} n -- t{*(GlyphInfo*)}	( font codepoint -- )
c-function GetGlyphAtlasRec GetGlyphAtlasRec a{*(Font*)} n -- t{*(Rectangle*)}	( font codepoint -- )
c-function LoadUTF8 LoadUTF8 a n -- a	( codepoints length -- )
c-function UnloadUTF8 UnloadUTF8 a -- void	( text -- )
c-function LoadCodepoints LoadCodepoints s a -- a	( text count -- )
c-function UnloadCodepoints UnloadCodepoints a -- void	( codepoints -- )
c-function GetCodepointCount GetCodepointCount s -- n	( text -- )
c-function GetCodepoint GetCodepoint s a -- n	( text codepointSize -- )
c-function GetCodepointNext GetCodepointNext s a -- n	( text codepointSize -- )
c-function GetCodepointPrevious GetCodepointPrevious s a -- n	( text codepointSize -- )
c-function CodepointToUTF8 CodepointToUTF8 n a -- s	( codepoint utf8Size -- )
c-function LoadTextLines LoadTextLines s a -- a	( text count -- )
c-function UnloadTextLines UnloadTextLines a n -- void	( text lineCount -- )
c-function TextCopy TextCopy a s -- n	( dst src -- )
c-function TextIsEqual TextIsEqual s s -- n	( text1 text2 -- )
c-function TextLength TextLength s -- u	( text -- )
c-function TextFormat TextFormat s ... -- s	( text <noname> -- )
c-function TextSubtext TextSubtext s n n -- s	( text position length -- )
c-function TextRemoveSpaces TextRemoveSpaces s -- s	( text -- )
c-function GetTextBetween GetTextBetween s s s -- a	( text begin end -- )
c-function TextReplace TextReplace s s s -- a	( text search replacement -- )
c-function TextReplaceAlloc TextReplaceAlloc s s s -- a	( text search replacement -- )
c-function TextReplaceBetween TextReplaceBetween s s s s -- a	( text begin end replacement -- )
c-function TextReplaceBetweenAlloc TextReplaceBetweenAlloc s s s s -- a	( text begin end replacement -- )
c-function TextInsert TextInsert s s n -- a	( text insert position -- )
c-function TextInsertAlloc TextInsertAlloc s s n -- a	( text insert position -- )
c-function TextJoin TextJoin a n s -- a	( textList count delimiter -- )
c-function TextSplit TextSplit s u a -- a	( text delimiter count -- )
c-function TextAppend TextAppend a s a -- void	( text append position -- )
c-function TextFindIndex TextFindIndex s s -- n	( text search -- )
c-function TextToUpper TextToUpper s -- a	( text -- )
c-function TextToLower TextToLower s -- a	( text -- )
c-function TextToPascal TextToPascal s -- a	( text -- )
c-function TextToSnake TextToSnake s -- a	( text -- )
c-function TextToCamel TextToCamel s -- a	( text -- )
c-function TextToInteger TextToInteger s -- n	( text -- )
c-function TextToFloat TextToFloat s -- r	( text -- )
c-function DrawLine3D DrawLine3D a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( startPos endPos color -- )
c-function DrawPoint3D DrawPoint3D a{*(Vector3*)} a{*(Color*)} -- void	( position color -- )
c-function DrawCircle3D DrawCircle3D a{*(Vector3*)} r a{*(Vector3*)} r a{*(Color*)} -- void	( center radius rotationAxis rotationAngle color -- )
c-function DrawTriangle3D DrawTriangle3D a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleStrip3D DrawTriangleStrip3D a n a{*(Color*)} -- void	( points pointCount color -- )
c-function DrawCube DrawCube a{*(Vector3*)} r r r a{*(Color*)} -- void	( position width height length color -- )
c-function DrawCubeV DrawCubeV a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawCubeWires DrawCubeWires a{*(Vector3*)} r r r a{*(Color*)} -- void	( position width height length color -- )
c-function DrawCubeWiresV DrawCubeWiresV a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawSphere DrawSphere a{*(Vector3*)} r a{*(Color*)} -- void	( centerPos radius color -- )
c-function DrawSphereEx DrawSphereEx a{*(Vector3*)} r n n a{*(Color*)} -- void	( centerPos radius rings slices color -- )
c-function DrawSphereWires DrawSphereWires a{*(Vector3*)} r n n a{*(Color*)} -- void	( centerPos radius rings slices color -- )
c-function DrawCylinder DrawCylinder a{*(Vector3*)} r r r n a{*(Color*)} -- void	( position radiusTop radiusBottom height slices color -- )
c-function DrawCylinderEx DrawCylinderEx a{*(Vector3*)} a{*(Vector3*)} r r n a{*(Color*)} -- void	( startPos endPos startRadius endRadius sides color -- )
c-function DrawCylinderWires DrawCylinderWires a{*(Vector3*)} r r r n a{*(Color*)} -- void	( position radiusTop radiusBottom height slices color -- )
c-function DrawCylinderWiresEx DrawCylinderWiresEx a{*(Vector3*)} a{*(Vector3*)} r r n a{*(Color*)} -- void	( startPos endPos startRadius endRadius sides color -- )
c-function DrawCapsule DrawCapsule a{*(Vector3*)} a{*(Vector3*)} r n n a{*(Color*)} -- void	( startPos endPos radius slices rings color -- )
c-function DrawCapsuleWires DrawCapsuleWires a{*(Vector3*)} a{*(Vector3*)} r n n a{*(Color*)} -- void	( startPos endPos radius slices rings color -- )
c-function DrawPlane DrawPlane a{*(Vector3*)} a{*(Vector2*)} a{*(Color*)} -- void	( centerPos size color -- )
c-function DrawRay DrawRay a{*(Ray*)} a{*(Color*)} -- void	( ray color -- )
c-function DrawGrid DrawGrid n r -- void	( slices spacing -- )
c-function LoadModel LoadModel s -- t{*(Model*)}	( fileName -- )
c-function LoadModelFromMesh LoadModelFromMesh a{*(Mesh*)} -- t{*(Model*)}	( mesh -- )
c-function IsModelValid IsModelValid a{*(Model*)} -- n	( model -- )
c-function UnloadModel UnloadModel a{*(Model*)} -- void	( model -- )
c-function GetModelBoundingBox GetModelBoundingBox a{*(Model*)} -- t{*(BoundingBox*)}	( model -- )
c-function DrawModel DrawModel a{*(Model*)} a{*(Vector3*)} r a{*(Color*)} -- void	( model position scale tint -- )
c-function DrawModelEx DrawModelEx a{*(Model*)} a{*(Vector3*)} a{*(Vector3*)} r a{*(Vector3*)} a{*(Color*)} -- void	( model position rotationAxis rotationAngle scale tint -- )
c-function DrawModelWires DrawModelWires a{*(Model*)} a{*(Vector3*)} r a{*(Color*)} -- void	( model position scale tint -- )
c-function DrawModelWiresEx DrawModelWiresEx a{*(Model*)} a{*(Vector3*)} a{*(Vector3*)} r a{*(Vector3*)} a{*(Color*)} -- void	( model position rotationAxis rotationAngle scale tint -- )
c-function DrawBoundingBox DrawBoundingBox a{*(BoundingBox*)} a{*(Color*)} -- void	( box color -- )
c-function DrawBillboard DrawBillboard a{*(Camera3D*)} a{*(Texture*)} a{*(Vector3*)} r a{*(Color*)} -- void	( camera texture position scale tint -- )
c-function DrawBillboardRec DrawBillboardRec a{*(Camera3D*)} a{*(Texture*)} a{*(Rectangle*)} a{*(Vector3*)} a{*(Vector2*)} a{*(Color*)} -- void	( camera texture source position size tint -- )
c-function DrawBillboardPro DrawBillboardPro a{*(Camera3D*)} a{*(Texture*)} a{*(Rectangle*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( camera texture source position up size origin rotation tint -- )
c-function UploadMesh UploadMesh a n -- void	( mesh dynamic -- )
c-function UpdateMeshBuffer UpdateMeshBuffer a{*(Mesh*)} n a n n -- void	( mesh index data dataSize offset -- )
c-function UnloadMesh UnloadMesh a{*(Mesh*)} -- void	( mesh -- )
c-function DrawMesh DrawMesh a{*(Mesh*)} a{*(Material*)} a{*(Matrix*)} -- void	( mesh material transform -- )
c-function DrawMeshInstanced DrawMeshInstanced a{*(Mesh*)} a{*(Material*)} a n -- void	( mesh material transforms instances -- )
c-function GetMeshBoundingBox GetMeshBoundingBox a{*(Mesh*)} -- t{*(BoundingBox*)}	( mesh -- )
c-function GenMeshTangents GenMeshTangents a -- void	( mesh -- )
c-function ExportMesh ExportMesh a{*(Mesh*)} s -- n	( mesh fileName -- )
c-function ExportMeshAsCode ExportMeshAsCode a{*(Mesh*)} s -- n	( mesh fileName -- )
c-function GenMeshPoly GenMeshPoly n r -- t{*(Mesh*)}	( sides radius -- )
c-function GenMeshPlane GenMeshPlane r r n n -- t{*(Mesh*)}	( width length resX resZ -- )
c-function GenMeshCube GenMeshCube r r r -- t{*(Mesh*)}	( width height length -- )
c-function GenMeshSphere GenMeshSphere r n n -- t{*(Mesh*)}	( radius rings slices -- )
c-function GenMeshHemiSphere GenMeshHemiSphere r n n -- t{*(Mesh*)}	( radius rings slices -- )
c-function GenMeshCylinder GenMeshCylinder r r n -- t{*(Mesh*)}	( radius height slices -- )
c-function GenMeshCone GenMeshCone r r n -- t{*(Mesh*)}	( radius height slices -- )
c-function GenMeshTorus GenMeshTorus r r n n -- t{*(Mesh*)}	( radius size radSeg sides -- )
c-function GenMeshKnot GenMeshKnot r r n n -- t{*(Mesh*)}	( radius size radSeg sides -- )
c-function GenMeshHeightmap GenMeshHeightmap a{*(Image*)} a{*(Vector3*)} -- t{*(Mesh*)}	( heightmap size -- )
c-function GenMeshCubicmap GenMeshCubicmap a{*(Image*)} a{*(Vector3*)} -- t{*(Mesh*)}	( cubicmap cubeSize -- )
c-function LoadMaterials LoadMaterials s a -- a	( fileName materialCount -- )
c-function LoadMaterialDefault LoadMaterialDefault  -- t{*(Material*)}	( -- )
c-function IsMaterialValid IsMaterialValid a{*(Material*)} -- n	( material -- )
c-function UnloadMaterial UnloadMaterial a{*(Material*)} -- void	( material -- )
c-function SetMaterialTexture SetMaterialTexture a n a{*(Texture*)} -- void	( material mapType texture -- )
c-function SetModelMeshMaterial SetModelMeshMaterial a n n -- void	( model meshId materialId -- )
c-function LoadModelAnimations LoadModelAnimations s a -- a	( fileName animCount -- )
c-function UpdateModelAnimation UpdateModelAnimation a{*(Model*)} a{*(ModelAnimation*)} r -- void	( model anim frame -- )
c-function UpdateModelAnimationEx UpdateModelAnimationEx a{*(Model*)} a{*(ModelAnimation*)} r a{*(ModelAnimation*)} r r -- void	( model animA frameA animB frameB blend -- )
c-function UnloadModelAnimations UnloadModelAnimations a n -- void	( animations animCount -- )
c-function IsModelAnimationValid IsModelAnimationValid a{*(Model*)} a{*(ModelAnimation*)} -- n	( model anim -- )
c-function CheckCollisionSpheres CheckCollisionSpheres a{*(Vector3*)} r a{*(Vector3*)} r -- n	( center1 radius1 center2 radius2 -- )
c-function CheckCollisionBoxes CheckCollisionBoxes a{*(BoundingBox*)} a{*(BoundingBox*)} -- n	( box1 box2 -- )
c-function CheckCollisionBoxSphere CheckCollisionBoxSphere a{*(BoundingBox*)} a{*(Vector3*)} r -- n	( box center radius -- )
c-function GetRayCollisionSphere GetRayCollisionSphere a{*(Ray*)} a{*(Vector3*)} r -- t{*(RayCollision*)}	( ray center radius -- )
c-function GetRayCollisionBox GetRayCollisionBox a{*(Ray*)} a{*(BoundingBox*)} -- t{*(RayCollision*)}	( ray box -- )
c-function GetRayCollisionMesh GetRayCollisionMesh a{*(Ray*)} a{*(Mesh*)} a{*(Matrix*)} -- t{*(RayCollision*)}	( ray mesh transform -- )
c-function GetRayCollisionTriangle GetRayCollisionTriangle a{*(Ray*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} -- t{*(RayCollision*)}	( ray p1 p2 p3 -- )
c-function GetRayCollisionQuad GetRayCollisionQuad a{*(Ray*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} -- t{*(RayCollision*)}	( ray p1 p2 p3 p4 -- )
c-function InitAudioDevice InitAudioDevice  -- void	( -- )
c-function CloseAudioDevice CloseAudioDevice  -- void	( -- )
c-function IsAudioDeviceReady IsAudioDeviceReady  -- n	( -- )
c-function SetMasterVolume SetMasterVolume r -- void	( volume -- )
c-function GetMasterVolume GetMasterVolume  -- r	( -- )
c-function LoadWave LoadWave s -- t{*(Wave*)}	( fileName -- )
c-function LoadWaveFromMemory LoadWaveFromMemory s a n -- t{*(Wave*)}	( fileType fileData dataSize -- )
c-function IsWaveValid IsWaveValid a{*(Wave*)} -- n	( wave -- )
c-function LoadSound LoadSound s -- t{*(Sound*)}	( fileName -- )
c-function LoadSoundFromWave LoadSoundFromWave a{*(Wave*)} -- t{*(Sound*)}	( wave -- )
c-function LoadSoundAlias LoadSoundAlias a{*(Sound*)} -- t{*(Sound*)}	( source -- )
c-function IsSoundValid IsSoundValid a{*(Sound*)} -- n	( sound -- )
c-function UpdateSound UpdateSound a{*(Sound*)} a n -- void	( sound data sampleCount -- )
c-function UnloadWave UnloadWave a{*(Wave*)} -- void	( wave -- )
c-function UnloadSound UnloadSound a{*(Sound*)} -- void	( sound -- )
c-function UnloadSoundAlias UnloadSoundAlias a{*(Sound*)} -- void	( alias -- )
c-function ExportWave ExportWave a{*(Wave*)} s -- n	( wave fileName -- )
c-function ExportWaveAsCode ExportWaveAsCode a{*(Wave*)} s -- n	( wave fileName -- )
c-function PlaySound PlaySound a{*(Sound*)} -- void	( sound -- )
c-function StopSound StopSound a{*(Sound*)} -- void	( sound -- )
c-function PauseSound PauseSound a{*(Sound*)} -- void	( sound -- )
c-function ResumeSound ResumeSound a{*(Sound*)} -- void	( sound -- )
c-function IsSoundPlaying IsSoundPlaying a{*(Sound*)} -- n	( sound -- )
c-function SetSoundVolume SetSoundVolume a{*(Sound*)} r -- void	( sound volume -- )
c-function SetSoundPitch SetSoundPitch a{*(Sound*)} r -- void	( sound pitch -- )
c-function SetSoundPan SetSoundPan a{*(Sound*)} r -- void	( sound pan -- )
c-function WaveCopy WaveCopy a{*(Wave*)} -- t{*(Wave*)}	( wave -- )
c-function WaveCrop WaveCrop a n n -- void	( wave initFrame finalFrame -- )
c-function WaveFormat WaveFormat a n n n -- void	( wave sampleRate sampleSize channels -- )
c-function LoadWaveSamples LoadWaveSamples a{*(Wave*)} -- a	( wave -- )
c-function UnloadWaveSamples UnloadWaveSamples a -- void	( samples -- )
c-function LoadMusicStream LoadMusicStream s -- t{*(Music*)}	( fileName -- )
c-function LoadMusicStreamFromMemory LoadMusicStreamFromMemory s a n -- t{*(Music*)}	( fileType data dataSize -- )
c-function IsMusicValid IsMusicValid a{*(Music*)} -- n	( music -- )
c-function UnloadMusicStream UnloadMusicStream a{*(Music*)} -- void	( music -- )
c-function PlayMusicStream PlayMusicStream a{*(Music*)} -- void	( music -- )
c-function IsMusicStreamPlaying IsMusicStreamPlaying a{*(Music*)} -- n	( music -- )
c-function UpdateMusicStream UpdateMusicStream a{*(Music*)} -- void	( music -- )
c-function StopMusicStream StopMusicStream a{*(Music*)} -- void	( music -- )
c-function PauseMusicStream PauseMusicStream a{*(Music*)} -- void	( music -- )
c-function ResumeMusicStream ResumeMusicStream a{*(Music*)} -- void	( music -- )
c-function SeekMusicStream SeekMusicStream a{*(Music*)} r -- void	( music position -- )
c-function SetMusicVolume SetMusicVolume a{*(Music*)} r -- void	( music volume -- )
c-function SetMusicPitch SetMusicPitch a{*(Music*)} r -- void	( music pitch -- )
c-function SetMusicPan SetMusicPan a{*(Music*)} r -- void	( music pan -- )
c-function GetMusicTimeLength GetMusicTimeLength a{*(Music*)} -- r	( music -- )
c-function GetMusicTimePlayed GetMusicTimePlayed a{*(Music*)} -- r	( music -- )
c-function LoadAudioStream LoadAudioStream u u u -- t{*(AudioStream*)}	( sampleRate sampleSize channels -- )
c-function IsAudioStreamValid IsAudioStreamValid a{*(AudioStream*)} -- n	( stream -- )
c-function UnloadAudioStream UnloadAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function UpdateAudioStream UpdateAudioStream a{*(AudioStream*)} a n -- void	( stream data frameCount -- )
c-function IsAudioStreamProcessed IsAudioStreamProcessed a{*(AudioStream*)} -- n	( stream -- )
c-function PlayAudioStream PlayAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function PauseAudioStream PauseAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function ResumeAudioStream ResumeAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function IsAudioStreamPlaying IsAudioStreamPlaying a{*(AudioStream*)} -- n	( stream -- )
c-function StopAudioStream StopAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function SetAudioStreamVolume SetAudioStreamVolume a{*(AudioStream*)} r -- void	( stream volume -- )
c-function SetAudioStreamPitch SetAudioStreamPitch a{*(AudioStream*)} r -- void	( stream pitch -- )
c-function SetAudioStreamPan SetAudioStreamPan a{*(AudioStream*)} r -- void	( stream pan -- )
c-function SetAudioStreamBufferSizeDefault SetAudioStreamBufferSizeDefault n -- void	( size -- )
c-function SetAudioStreamCallback SetAudioStreamCallback a{*(AudioStream*)} a -- void	( stream callback -- )
c-function AttachAudioStreamProcessor AttachAudioStreamProcessor a{*(AudioStream*)} a -- void	( stream processor -- )
c-function DetachAudioStreamProcessor DetachAudioStreamProcessor a{*(AudioStream*)} a -- void	( stream processor -- )
c-function AttachAudioMixedProcessor AttachAudioMixedProcessor a -- void	( processor -- )
c-function DetachAudioMixedProcessor DetachAudioMixedProcessor a -- void	( processor -- )

\ ----===< postfix >===-----
end-c-library

\ include color constants
require raylib-colors.fs

\ include helpers
require raylib-helpers.fs
