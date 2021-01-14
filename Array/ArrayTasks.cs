using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            int firsr_number = 0;
            int second_number = nums.Length - 1;
    
            for (int count = nums.Length / 2; count > 0; count--, firsr_number++, second_number--)
            {
                int x = nums[firsr_number];                
                int y = nums[second_number];             
                if (nums[firsr_number] % 2 == 0 && nums[second_number] % 2 == 0) {               
                    nums[firsr_number] = nums[firsr_number] + nums[second_number];
                    nums[second_number] = nums[firsr_number] - nums[second_number]; 
                    nums[firsr_number] = nums[firsr_number] - nums[second_number];                 
                }
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {           
            int max = nums[0];
            int biggest_value_position = 0;
            int second_value_position = 0;
            int gap = 0;
            for (int position = 1; position < nums.Length; position++)
            {
                if (nums[position] > max)
                {
                    max = nums[position];
                    biggest_value_position = position;
                }
                if (nums[position] == max) second_value_position = position;
            }
            gap = second_value_position - biggest_value_position;
            return gap;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
            {
              for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
                {
                    if (i < j) matrix[i, j] = 0;
                    else if (i > j) matrix[i, j] = 1;
                }
               
            }
            
            throw new NotImplementedException();
        }
    }
}
