namespace Upsilon.Apps.PassKey.Interfaces.Events
{
   /// <summary>
   /// Represent a warning detected event argument.
   /// </summary>
   /// <param name="warning">The warnings detected.</param>
   public sealed class WarningDetectedEventArgs(IWarning[] warning) : EventArgs
   {
      /// <summary>
      /// The warnings detected.
      /// </summary>
      public IWarning[] Warnings { get; private set; } = warning;
   }
}
