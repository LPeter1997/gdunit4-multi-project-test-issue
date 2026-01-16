// ISSUE 2 again
using GdUnit4;
using MultiProjectTestIssue.src;
using System.Threading.Tasks;

namespace Tests.test;

[TestSuite]
[RequireGodotRuntime]
public sealed class SampleTest
{
    [TestCase]
    public async Task Simple()
    {
        using var runner = ISceneRunner.Load("res://src/game_controller.tscn");
        var root = (GameController)runner.Scene()!;

        await runner.SimulateFrames(5);
        runner.SimulateKeyPress(Godot.Key.Space);
        await runner.SimulateFrames(5);

        Assertions.AssertThat(root.Counter).IsEqual(1);
    }
}
