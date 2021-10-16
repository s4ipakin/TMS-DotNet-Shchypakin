namespace TeachMeSkills.Shchypakin.Homework_7.Data
{
    /// <summary>
    /// Stores data of a fitness routine
    /// </summary>
    public class WorkOutRoutine
    {
        /// <summary>
        /// Amount of minutes spent on the routine
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// Messured weight after workingout
        /// </summary>
        public double WeightAfter { get; set; }

        /// <summary>
        /// Messured heart pulse rate per minute
        /// </summary>
        public int PulseAfter { get; set; }

        /// <summary>
        /// Is the routine consisted of anaerobic exercises
        /// </summary>
        public bool IsAnaerobic { get; set; }
    }
}