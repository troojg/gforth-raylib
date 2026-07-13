require ../raylib.fs
require ../raylib-colors.fs

\ This is the Basic Window example, more or less

: start-test 
    400 300 s" test window situation" InitWindow
    60 SetTargetFPS

    begin
        BeginDrawing
        RAYWHITE ClearBackground
        s" here i come, catjam!!!"
        30 150 24 \ x, y, and font size
        DARKGRAY DrawText
        EndDrawing
    WindowShouldClose until

    CloseWindow
;

start-test
