using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Converts a Vector2 into a Vector3. Transformation is XY -> XZ.
    /// </summary>
    /// <param name="vector2">Value to be converted to Vector3.</param>
    /// <returns></returns>
    public static Vector3 ToVector3(this Vector2 vector2)
    {
        return new Vector3(vector2.x, 0f, vector2.y);
    }

    /// <summary>
    /// Flips the variable and returns new state.
    /// </summary>
    /// <param name="b">Value to be toggled.</param>
    public static bool Toggle(this ref bool b)
    {
        b = !b;
        return b;
    }

    // TODO: Document and push to GitHub
    public static Vector2 ToVector2(this Vector3 vector3)
    {
        return new Vector2(vector3.x, vector3.y);
    }

}