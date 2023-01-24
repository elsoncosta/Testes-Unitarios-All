namespace calculos
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Método de arredondamento "round-half-even
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundAbnt(this decimal value)
        {
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Método de arredondamento "round-half-even
        /// </summary>
        /// <param name="value"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static decimal RoundAbnt(this decimal value, int precision)
        {
            return Math.Round(value, precision, MidpointRounding.ToEven);
        }
    }
}