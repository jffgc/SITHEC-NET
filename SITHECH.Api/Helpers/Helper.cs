namespace SITHECH.Api.Helpers
{
    public static class Helper
    {
        public static string Calculate(float value1, int mathOperator, float value2)
        {
            string message = string.Empty;
            float result = 0;
            switch (mathOperator)
            {
                case 1:
                    result = value1 + value2;
                    message = "LA SUMA ES " + result.ToString();
                    break;
                case 2:
                    result = value1 - value2;
                    message = "LA RESTA ES " + result.ToString();
                    break;
                case 3:
                    result = value1 * value2;
                    message = "LA MULTIPLICACION ES " + result.ToString();
                    break;
                case 4:
                    (float division, string messageError) = ValidateDivision(value1, value2);
                    if (string.IsNullOrEmpty(messageError))
                    {
                        result = value1 / value2;
                        message = "LA DIVISION ES " + result.ToString();
                    }
                    else
                    {
                        throw new Exception(messageError);
                    }
                    break;
            }
            return message;
        }

        public static (bool, string) ValidateOperator(int mathOperator)
        {
            bool flag = true;
            string message = string.Empty;
            if (mathOperator < 1 || mathOperator > 4)
            {
                flag = false;
                message = "El operador no es válido";
            }
            return (flag, message);
        }

        public static (float, string) ValidateDivision(float value1, float value2)
        {
            float result = 0;
            string message = string.Empty;
            if (value1 != 0)
            {
                result = value1 / value2;
            }
            else
            {
                message = "El valor 1 no puede ser 0";
            }
            return (result, message);
        }
    }
}
