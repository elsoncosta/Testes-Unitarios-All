namespace calculos
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Método de arredondamento "ToEven: A estratégia de arredondar
        /// para o número mais próximo e, quando um número estiver no meio
        /// do caminho entre outros dois, ela é arredondada em direção ao
        /// número par mais próximo."
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundAbnt(this decimal value)
        {
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Método de arredondamento "ToEven: A estratégia de arredondar
        /// para o número mais próximo e, quando um número estiver no meio
        /// do caminho entre outros dois, ela é arredondada em direção ao
        /// número par mais próximo."
        /// </summary>
        /// <param name="value"></param>
        /// <param name="precision">Arredonda um valor decimal para um número
        /// especificado de dígitos fracionários usando a convenção de
        /// arredondamento especificada.</param>
        /// <returns></returns>
        public static decimal RoundAbnt(this decimal value, int precision)
        {
            return Math.Round(value, precision, MidpointRounding.ToEven);
        }
    }
}