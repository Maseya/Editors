﻿// <copyright file="IEditor.cs" company="Public Domain">
//     Copyright (c) 2019 Nelson Garcia. All rights reserved. Licensed under
//     GNU Affero General Public License. See LICENSE in project root for full
//     license information, or visit https://www.gnu.org/licenses/#AGPL
// </copyright>

namespace Maseya.Editors
{
    using System;
    using Maseya.Helper;

    /// <summary>
    /// Provides properties and methods for general design-editing
    /// functionality.
    /// </summary>
    public interface IEditor
    {
        event EventHandler PathChanged;

        event EventHandler<CancelEventArgs> BeginUndo;

        event EventHandler UndoComplete;

        event EventHandler<CancelEventArgs> BeginRedo;

        event EventHandler RedoComplete;

        event EventHandler<CancelEventArgs> BeginCut;

        event EventHandler CutComplete;

        event EventHandler<CancelEventArgs> BeginCopy;

        event EventHandler CopyComplete;

        event EventHandler<CancelEventArgs> BeginPaste;

        event EventHandler PasteComplete;

        event EventHandler<CancelEventArgs> BeginDelete;

        event EventHandler DeleteComplete;

        event EventHandler<CancelEventArgs> BeginSelectAll;

        event EventHandler SelectAllComplete;

        event EventHandler<CancelEventArgs> SelectionChanging;

        event EventHandler SelectionChanged;

        event EventHandler<CancelEventArgs> BeginWriteData;

        event EventHandler WriteDataComplete;

        string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Undo"/>.
        /// </summary>
        bool CanUndo
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Redo"/>.
        /// </summary>
        bool CanRedo
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Cut"/>.
        /// </summary>
        bool CanCut
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Copy"/>.
        /// </summary>
        bool CanCopy
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Paste"/>.
        /// </summary>
        bool CanPaste
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="Delete"/>.
        /// </summary>
        bool CanDelete
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance of <see
        /// cref="IEditor"/> can invoke <see cref="SelectAll"/>.
        /// </summary>
        bool CanSelectAll
        {
            get;
        }

        /// <summary>
        /// Undoes the last write applied to this <see cref="IEditor"/>.
        /// </summary>
        void Undo();

        /// <summary>
        /// Redoes the last action undone to this <see cref="IEditor"/>.
        /// </summary>
        void Redo();

        /// <summary>
        /// Copies the selected data of this <see cref="IEditor"/> and then
        /// deletes that selection in the <see cref="IEditor"/>.
        /// </summary>
        void Cut();

        /// <summary>
        /// Copies the selected data of this <see cref="IEditor"/>.
        /// </summary>
        void Copy();

        /// <summary>
        /// Pastes the last copied <see cref="IEditor"/> data selection to the
        /// current selection of this <see cref="IEditor"/>.
        /// </summary>
        void Paste();

        /// <summary>
        /// Deletes the contents of the current selection of this <see
        /// cref="IEditor"/>.
        /// </summary>
        void Delete();

        /// <summary>
        /// Places all data in this <see cref="IEditor"/> into the current
        /// selection.
        /// </summary>
        void SelectAll();
    }
}
