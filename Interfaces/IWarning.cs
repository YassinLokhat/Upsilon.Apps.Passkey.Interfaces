﻿using Upsilon.Apps.PassKey.Interfaces.Enums;

namespace Upsilon.Apps.PassKey.Interfaces
{
   /// <summary>
   /// Represent a warning.
   /// </summary>
   public interface IWarning
   {
      /// <summary>
      /// The type of the warning.
      /// </summary>
      WarningType WarningType { get; }

      /// <summary>
      /// The logs concerned to the warning, if exists.
      /// </summary>
      ILog[]? Logs { get; }

      /// <summary>
      /// The accounts concerned to the warning, if exists.
      /// </summary>
      IAccount[]? Accounts { get; }
   }
}
