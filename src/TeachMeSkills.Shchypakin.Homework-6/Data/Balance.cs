namespace TeachMeSkills.Shchypakin.Homework_6.Data
{
    public class Balance
    {
        /// <summary>
        /// Actual balance
        /// </summary>
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// ID of the last operation
        /// </summary>
        public int LastOperationId { get; set; }
    }
}