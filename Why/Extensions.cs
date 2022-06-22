﻿using OpenTK.Mathematics;

namespace Why
{
    public static class Extensions
    {
        public static string contentToString<T>(this T[] arr)
        {
            string o = arr.ToString() ?? string.Empty;
            o = o[..^1];
            foreach (var item in arr)
            {
                o += item + ", ";
            }
            o = o[..^2];
            o += "]";
            return o;
        }

        public static Vector2 normalizedFast(this Vector2 vec)
        {
            var length = MathHelper.InverseSqrtFast((float) (vec.X * (double) vec.X + vec.Y * (double) vec.Y));
            vec.X *= length;
            vec.Y *= length;
            return vec;
        }

        public static Vector3 normalizedFast(this Vector3 vec)
        {
            var length = MathHelper.InverseSqrtFast((float) (vec.X * (double) vec.X + vec.Y * (double) vec.Y + vec.Z * (double) vec.Z));
            vec.X *= length;
            vec.Y *= length;
            vec.Z *= length;
            return vec;
        }
        
        public static float toRadians(this float degrees)
        {
            return degrees * (float) Math.PI / 180f;
        }
        
        public static float toDegrees(this float radians)
        {
            return radians * 180f / (float) Math.PI;
        }

        public static void scale(this ref Matrix4 matrix4, float scalar)
        {
            matrix4 *= Matrix4.CreateScale(scalar);
        }
        
        public static void scale(this ref Matrix4 matrix4, Vector3 scalar)
        {
            matrix4 *= Matrix4.CreateScale(scalar);
        }
        
        public static void scale(this ref Matrix4 matrix4, float x, float y, float z)
        {
            matrix4 *= Matrix4.CreateScale(x, y, z);
        }
        
        public static void translate(this ref Matrix4 matrix4, Vector3 translation)
        {
            matrix4 *= Matrix4.CreateTranslation(translation);
        }
        
        public static void translate(this ref Matrix4 matrix4, float x, float y, float z)
        {
            matrix4 *= Matrix4.CreateTranslation(x, y, z);
        }
        
        public static void rotate(this ref Matrix4 matrix4, float angle, Vector3 axis)
        {
            matrix4 *= Matrix4.CreateFromAxisAngle(axis, angle);
        }
        
        public static void rotate(this ref Matrix4 matrix4, float angle, float x, float y, float z)
        {
            matrix4 *= Matrix4.CreateFromAxisAngle(new Vector3(x, y, z), angle);
        }
    }
}