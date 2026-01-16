using Godot;
using System;

// ISSUE 2: this is the namespace structure IDEs will propose
// I think most will want to exclude the 'src' and 'test' segments, which are only there to support the symlink trick
namespace MultiProjectTestIssue.src;

public partial class GameController : Node2D
{
    public int Counter { get; set; }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("increment")) ++Counter;
    }
}
