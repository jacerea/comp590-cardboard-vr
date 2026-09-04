# COMP 590/790 — Assignment 1: Cardboard VR Target Game

A virtual reality target-shooting game built in Unity 6.5 for Google Cardboard.

## What it is

The player looks around in the headset to aim, and presses the Cardboard
button to fire a physics-based ball toward wherever they're facing. Balls
that hit the target increment the score. The player has 30 seconds to score
as many hits as possible, after which the game locks input and displays a
final score.

## Why it's a game

- Goal: maximize hits on the target before time runs out.
- Rules: one ball per button press, a fixed 30-second time limit, and
  ballistic physics that require leading the shot rather than aiming
  straight at the target. Pretty simple stuff.
- Feedback: score and countdown update live on a world-space HUD.
- Terminal state: the round ends and produces a final score that can be
  compared across attempts, which separates this from an open-ended toy.

## Implementation notes

- `ButtonClick.cs` (on the camera) fires a ball prefab along
  `Camera.main.transform.forward` using `ForceMode.Impulse`.
- `BallPrefab.cs` requires a Rigidbody, self-destructs after 5 seconds, and
  detects target hits by tag.
- `ScoreManager.cs` tracks score and the countdown, displayed via a
  World Space Canvas parented to the camera (screen-space UI does not
  render correctly across Cardboard's stereo split).
- The camera uses a Tracked Pose Driver so head rotation from the phone's
  IMU drives both the view and the aim direction.

## Contents

- `Assets/` — Unity project source
- `Builds/TargetGame.apk` — the game (Step 6)
- `Builds/HelloCardboard.apk` — the basic cube scene (Step 4)
- Deployment photos (PDF) showing the app running on Google Cardboard

## Sources

- Target texture: provided with the assignment
- [Google Cardboard XR Plugin for Unity](https://github.com/googlevr/cardboard-xr-plugin)
- Unity 6.5 (6000.5.9f1), Built-In Render Pipeline
