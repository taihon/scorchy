using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class UserLoggedInEventArgs : EventArgs
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the LoggedInUser info.
        /// </summary>
        public User LoggedInUser { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes an instance of <see cref="UserLoggedInEventArgs"/>.
        /// </summary>
        /// <param name="user">The logge in user model.</param>
        public UserLoggedInEventArgs(User user)
        {
            LoggedInUser = user;
        }

        #endregion


    }
}
