from splashkit import *

open_window("Triangle Quad Intersect", 800, 600)

# Create a fixed quad
target_quad = quad_from(
    450, 180,
    650, 180,
    450, 380,
    650, 380
)

while not quit_requested():
    process_events()

    # Get current mouse position
    mouse_pt = mouse_position()
    mx = mouse_pt.x
    my = mouse_pt.y

    # Triangle coordinates
    x1 = mx
    y1 = my - 60

    x2 = mx - 60
    y2 = my + 50

    x3 = mx + 60
    y3 = my + 50

    # Create the moving triangle
    moving_triangle = triangle_from_coordinates(
        x1, y1,
        x2, y2,
        x3, y3
    )

    # Test whether the triangle intersects the quad
    intersects = triangle_quad_intersect(
        moving_triangle,
        target_quad
    )

    clear_screen(color_white())

    # Draw the fixed quad
    fill_quad(color_light_gray(), target_quad)
    draw_quad(color_black(), target_quad)

    # Change triangle colour depending on intersection
    if intersects:
        fill_triangle(
            color_red(),
            x1, y1,
            x2, y2,
            x3, y3
        )

        draw_text_no_font_no_size(
            "Triangle intersects the quad!",
            color_red(),
            20,
            20
        )
    else:
        fill_triangle(
            color_blue(),
            x1, y1,
            x2, y2,
            x3, y3
        )

        draw_text_no_font_no_size(
            "Move the triangle into the quad",
            color_black(),
            20,
            20
        )

    # Draw triangle outline
    draw_triangle(
        color_black(),
        x1, y1,
        x2, y2,
        x3, y3
    )

    refresh_screen()

close_all_windows()