﻿using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"source cannot be null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"source cannot be empty.");
            }

            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
