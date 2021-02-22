namespace parking_problem
{
    public class customer
    {
        private float parking_time { get; set; }
        private float parking_charges { get; set; }
        private int Id { get; set; }

        public customer(float parkingTime, int id)
        {
            Id = id;
            parking_time = parkingTime;
            parking_charges = 2;
        }

        public float CalculateCharges()
        {
            if (parking_time <= 0 || parking_time > 24)
            {
                parking_charges = 0;
            }
            if (parking_time > 3)
            {
                if (parking_time % 1f != 0f)
                    parking_time = parking_time % 1 + 1;
                parking_charges = 2 + (parking_time - 3) * 0.5f;
            }

            if (parking_charges > 10)
                parking_charges = 10;
            return parking_charges;
        }
    }
}