namespace ShapesSquaresAreas;

internal class ShapesAreas : IShapesAreas
{
    public bool CheckIfRightAngled(float sideA, float sideB, float sideC)
    {
        if (!CheckIfPositiveValue(sideA, sideB, sideC))
        {
            return false;
        }

        float max = Math.Max(sideA, sideB);

        if (sideC > max)
        {
            max = sideC;
        }

        bool isRightAngled = sideA * sideA == sideB * sideB + sideC * sideC
            || sideB * sideB == sideC * sideC + sideA * sideA
            || sideC * sideC == sideA * sideA + sideB * sideB;

        return isRightAngled;
    }

    public float GetArea(float radius)
    {
        if (!CheckIfPositiveValue(radius))
        {
            return 0.0f;
        }

        float roundArea = (float)(Math.PI * Math.Pow(radius, 2));

        return roundArea;
    }

    public float GetArea(float sideA, float sideB, float sideC)
    {
        if (!CheckIfPositiveValue(sideA, sideB, sideC))
        {
            return 0.0f;
        }

        float semiPerimeter = (sideA + sideB + sideC) / 2;
        float triangleArea = (float)Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        return triangleArea;
    }

    bool CheckIfPositiveValue(params float[] values)
    {
        foreach (float item in values)
        {
            if (item < 0)
            {
                return false;
            }
        }

        return true;
    }
}
