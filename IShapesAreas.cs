namespace ShapesSquaresAreas;

public interface IShapesAreas
{
    float GetArea(float radius);

    float GetArea(float sideA, float sideB, float sideC);

    bool CheckIfRightAngled(float sideA, float sideB, float sideC);
}
