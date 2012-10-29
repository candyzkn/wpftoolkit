﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

using System;
using System.Windows.Input;

namespace Xceed.Wpf.DataGrid
{
  public static class DataGridCommands
  {
    static DataGridCommands()
    {
      DataGridCommands.BeginEdit.InputGestures.Add( new KeyGesture( Key.F2, ModifierKeys.None ) );
      DataGridCommands.EndEdit.InputGestures.Add( new KeyGesture( Key.Enter, ModifierKeys.None ) );
      DataGridCommands.CancelEdit.InputGestures.Add( new KeyGesture( Key.Escape, ModifierKeys.None ) );

      DataGridCommands.Refresh.InputGestures.Add( new KeyGesture( Key.F5, ModifierKeys.None ) );

      DataGridCommands.ApplyFilter.InputGestures.Add( new KeyGesture( Key.Enter, ModifierKeys.None ) );
    }

    public static readonly RoutedCommand ExpandGroup =
      new RoutedCommand( "ExpandGroup", typeof( DataGridCommands ) );

    public static readonly RoutedCommand CollapseGroup = 
      new RoutedCommand( "CollapseGroup", typeof( DataGridCommands ) );

    public static readonly RoutedCommand ToggleGroupExpansion = 
      new RoutedCommand( "ToggleGroupExpansion", typeof( DataGridCommands ) );

    public static readonly RoutedCommand ExpandDetails =
      new RoutedCommand( "ExpandDetails", typeof( DataGridCommands ) );

    public static readonly RoutedCommand CollapseDetails =
      new RoutedCommand( "CollapseDetails", typeof( DataGridCommands ) );

    public static readonly RoutedCommand ToggleDetailExpansion =
      new RoutedCommand( "ToggleDetailExpansion", typeof( DataGridCommands ) );

    public static readonly RoutedCommand BeginEdit = 
      new RoutedCommand( "BeginEdit", typeof( DataGridCommands ) );

    public static readonly RoutedCommand EndEdit = 
      new RoutedCommand( "EndEdit", typeof( DataGridCommands ) );

    public static readonly RoutedCommand CancelEdit = 
      new RoutedCommand( "CancelEdit", typeof( DataGridCommands ) );

    [ Obsolete( "This command is obsolete and should no longer be used." ) ]
    public static readonly RoutedCommand SelectRow = 
      new RoutedCommand( "SelectRow", typeof( DataGridCommands ) );

    public static readonly RoutedCommand Refresh =
      new RoutedCommand( "Refresh", typeof( DataGridCommands ) );

    public static readonly RoutedCommand ApplyFilter =
      new RoutedCommand( "ApplyFilter", typeof( DataGridCommands ) );

    public static readonly RoutedCommand ClearFilter =
      new RoutedCommand( "ClearFilter", typeof( DataGridCommands ) );
  }
}