namespace GeometryClass
{
    public class Triangle
    {
        public static double TSquare(double a_side, double b_side, double c_side)
        {
            double semi_perimeter = (a_side + b_side + c_side) / 2;
            double square = Math.Sqrt(semi_perimeter * (semi_perimeter - a_side) * 
                (semi_perimeter - b_side) * (semi_perimeter - c_side));
            return square;
        }

        public static bool TRight(double a_side, double b_side, double c_side)
        {
            double[] array =  { a_side, b_side, c_side };
            Array.Sort(array);
            double square_c = Math.Pow(array[2], 2);
            double a_b_square_sum = Math.Pow(array[0], 2) + Math.Pow(array[1], 2);
            if (square_c == a_b_square_sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
