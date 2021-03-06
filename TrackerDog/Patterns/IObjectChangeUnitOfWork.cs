﻿namespace TrackerDog.Patterns
{
    /// <summary>
    /// Defines what should provide a basic unit of work to accept or discard object changes.
    /// </summary>
    public interface IObjectChangeUnitOfWork
    {
        /// <summary>
        /// Accepts all pending changes.
        /// </summary>
        void Complete();

        /// <summary>
        /// Discards all pending changes
        /// </summary>
        void Discard();
    }
}