﻿using Upsilon.Apps.PassKey.Interfaces.Enums;

namespace Upsilon.Apps.PassKey.Interfaces.Events
{
   /// <summary>
   /// Represent the behavior of auto-save handling event argument.
   /// </summary>
   public sealed class AutoSaveDetectedEventArgs : EventArgs
   {
      /// <summary>
      /// The behavior selected.
      /// By default it will merge then remove the auto-save file.
      /// </summary>
      public AutoSaveMergeBehavior MergeBehavior { get; set; } = AutoSaveMergeBehavior.MergeThenRemoveAutoSaveFile;
   }
}
