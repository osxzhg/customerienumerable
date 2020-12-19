namespace explicitlyImplement
{
    public class Box : IDimensions
    {
        float lengthInches;
        float widthInches;

        public Box()
        {
        }

        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }
        // Explicit interface member implementation:
        float IDimensions.GetLength()
        {
            return lengthInches;
        }
        // Explicit interface member implementation:
        float IDimensions.GetWidth()
        {
            return widthInches;
        }
    }

    }
