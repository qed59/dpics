namespace Simulation 
{
    /// <summary>
    /// Define the interface that our simulation framework uses to
    /// model the performance of rockets.
    /// </summary>
    public interface IRocketSim
    {
        /// <summary>
        /// Return the mass (in kilograms) of the simulated rocket at 
        /// the specified time.
        /// </summary>
        /// <returns>The mass at the specified time</returns>
        double GetMass();

        /// <summary>
        /// Return the force (in newtons) per second generated by the 
        /// simulated rocket.
        /// </summary>
        /// <returns>The thrust, in newtons per second</returns>
        double GetThrust();

        /// <summary>
        /// Update the current time based on the simulation clock's.
        /// </summary>
        /// <param name="t">the simulation clock's current time</param>
        void SetSimTime(double t);
    }
}