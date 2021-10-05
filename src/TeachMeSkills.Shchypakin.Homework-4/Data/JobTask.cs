using System;

namespace TeachMeSkills.Shchypakin.Homework_4.Data
{
    /// <summary>
    /// TaskClass.
    /// </summary>
    public class JobTask
    {
        private readonly string _id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        private readonly DateTime _dateTime = DateTime.Now;

        /// <summary>
        /// Id.
        /// </summary>
        public string Id => _id;

        /// <summary>
        /// DateTime.
        /// </summary>
        public DateTime DateTime => _dateTime;

        /// <summary>
        /// Status.
        /// </summary>
        public virtual JobTaskStatus Status { get; set; } = JobTaskStatus.Backlog;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// TaskDescription.
        /// </summary>
        public string Description { get; set; }
    }
}
