//
// CursorShape.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Standard cursor shapes.
    /// </summary>
    public enum CursorShape
    {
        /// <summary>
        /// The standard arrow shape. Used in almost all situations.
        /// </summary>
        Arrow = 0x00036001,

        /// <summary>
        /// The I-Beam shape. Used when mousing over a place where text can be entered.
        /// </summary>
        IBeam = 0x00036002,

        /// <summary>
        /// The crosshair shape. Used when dragging and dropping.
        /// </summary>
        Crosshair = 0x00036003,

        /// <summary>
        /// The hand shape. Used when mousing over something that can be dragged around.
        /// </summary>
        Hand = 0x00036004,

        /// <summary>
        /// The horizontal resize shape. Used when mousing over something that can be horizontally resized.
        /// </summary>
        HResize = 0x00036005,

        /// <summary>
        /// The vertical resize shape. Used when mousing over something that can be vertically resized.
        /// </summary>
        VResize = 0x00036006,

        /// <summary>
        /// The top-left to bottom-right diagonal resize shape. Used when mousing over something that can be diagonally resized.
        /// </summary>
        NWSEResize = 0x00036007,

        /// <summary>
        /// The top-right to bottom-left diagonal resize shape. Used when mousing over something that can be diagonally resized.
        /// </summary>
        NESWResize = 0x00036008,

        /// <summary>
        /// The omni-directional move shape. Used when mousing over something that can be moved.
        /// </summary>
        AllResize = 0x00036009,

        /// <summary>
        /// The operation-not-allowed shape. Used when mousing over something that is not interactable.
        /// </summary>
        NotAllowed = 0x0003600A
    }
}
