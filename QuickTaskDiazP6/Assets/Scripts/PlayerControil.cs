using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControil : MonoBehaviour
{
    import turtle

# Set up the screen
wn = turtle.Screen()
wn.title("Player Control")
wn.bgcolor("white")
wn.setup(width=800, height=600)

# Create the player object
player = turtle.Turtle()
player.shape("square")
player.color("blue")
player.penup()
player.goto(0, -250)

# Player attributes
player_x_speed = 10
player_y_speed = 15
is_jumping = False

# Functions to move the player
def move_left() :
    x = player.xcor()
    x -= player_x_speed
    player.setx(x)

def move_right():
    x = player.xcor()
    x += player_x_speed
    player.setx(x)

def jump():
    global is_jumping
    if not is_jumping:
        is_jumping = True
        for _ in range(player_y_speed) :
            y = player.ycor()
            y += 1
            player.sety(y)
        for _ in range(player_y_speed) :
            y = player.ycor()
            y -= 1
            player.sety(y)
        is_jumping = False

# Keyboard bindings
wn.listen()
wn.onkeypress(move_left, "Left")
wn.onkeypress(move_right, "Right")
wn.onkeypress(jump, "space")

# Main game loop
while True:
    wn.update()

}
