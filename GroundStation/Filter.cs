namespace GroundStation
{
    class Filter
    {
        private readonly double[] IIRdelay = new double[2];
        private readonly double[] MoveSave = new double[8];
        private double UnitDelay;
        public double IIR_LowPassFilter(double DataIn)
        {
            IIRdelay[0] = DataIn + 0.76295 * IIRdelay[1] - 0.283438 * IIRdelay[2];
            double DataOut = 0.129 * IIRdelay[0] + 0.258 * IIRdelay[1] + 0.129 * IIRdelay[2];
            IIRdelay[2] = IIRdelay[1];
            IIRdelay[1] = IIRdelay[0];
            return DataOut;
        }
        public double Moving_Average(double DataIn)
        {
            double sum = DataIn;
            for (int i = 0; i < 7; i++)
            {
                MoveSave[i] = MoveSave[i + 1];
                sum += MoveSave[i];
            }
            MoveSave[7] = DataIn;
            return sum / 8.0;
        }
        public double OneOrder_Filter(double DataIn)
        {
            double DataOut = DataIn + 0.25 * UnitDelay;
            UnitDelay = DataOut;
            return DataOut * 0.75;
        }
    }
}
