﻿namespace MarsRover.Enums
{
    /// <summary>
    /// The orientation of a Rover.
    /// </summary>
    public enum Orientation
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }

    public static class OrientationExtensions
    {
        public static string ToFriendlyString(this Orientation orientation)
        {
            switch(orientation)
            {
                case Orientation.North:
                    return "N";
                case Orientation.East:
                    return "E";
                case Orientation.South:
                    return "S";
                case Orientation.West:
                    return "W";
                default:
                    return "Undefined";
            }
        }
    }
}
