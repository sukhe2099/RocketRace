namespace RocketRace
{
    public static class Factory
    {
        public static int GuyNumber = 0;
        public static Punter GetNameId(string name)
        {
            switch (name)
            {
                case "Sukhman":
                    GuyNumber = 0;
                    return new Sukhman();

                case "Anil":
                    GuyNumber = 1;
                    return new Anil();

                case "Al":
                    GuyNumber = 2;
                    return new Al();
            }
            return new Sukhman();
        }
    }
}
