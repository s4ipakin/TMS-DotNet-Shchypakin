using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_4.Data
{
    /// <summary>
    /// TaskNoteClass.
    /// </summary>
    public class TaskNote
    {
        private readonly string _id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        private readonly DateTime _dateTime = DateTime.Now;
        private TaskStatus _status = TaskStatus.Backlog;

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
        public TaskStatus Status => _status;

        /// <summary>
        /// TaskName.
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// TaskDescription.
        /// </summary>
        public string TaskDescription { get; set; }
    }
}
