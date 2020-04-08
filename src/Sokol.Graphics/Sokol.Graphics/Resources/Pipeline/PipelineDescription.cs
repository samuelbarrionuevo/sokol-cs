// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace Sokol.Graphics
{
    /// <summary>
    ///     Parameters for constructing a <see cref="Pipeline" />.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <see cref="PipelineDescription" /> specifies the rendering configuration state used during a rendering
    ///         <see cref="Pass" />, including rasterization (such as multi-sampling), visibility, blending, and
    ///         other graphics function state.
    ///     </para>
    ///     <para>
    ///         Use standard struct allocation and initialization techniques to create
    ///         a <see cref="PipelineDescription" />.
    ///     </para>
    ///     <para>
    ///         To specify the vertex or fragment function in the rendering <see cref="Pipeline" />, set the
    ///         <see cref="Shader"/> property.
    ///     </para>
    ///     <para>
    ///         <see cref="PipelineDescription" /> is blittable to the C `sg_pipeline_desc` struct found in `sokol_gfx`.
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 456, Pack = 8, CharSet = CharSet.Ansi)]
    public struct PipelineDescription
    {
        /// <summary>
        ///     The <see cref="PipelineVertexLayoutDescription" />.
        /// </summary>
        [FieldOffset(4)]
        public PipelineVertexLayoutDescription Layout;

        /// <summary>
        ///     The <see cref="Shader" /> resource.
        /// </summary>
        [FieldOffset(292)]
        public Shader Shader;

        /// <summary>
        ///     The <see cref="PipelineVertexPrimitiveType" />.
        /// </summary>
        [FieldOffset(296)]
        public PipelineVertexPrimitiveType PrimitiveType;

        /// <summary>
        ///     The <see cref="PipelineVertexIndexType" />.
        /// </summary>
        [FieldOffset(300)]
        public PipelineVertexIndexType IndexType;

        /// <summary>
        ///     The <see cref="PipelineDepthStencilState" />.
        /// </summary>
        [FieldOffset(304)]
        public PipelineDepthStencilState DepthStencil;

        /// <summary>
        ///     The <see cref="PipelineBlendState" />.
        /// </summary>
        [FieldOffset(348)]
        public PipelineBlendState Blend;

        /// <summary>
        ///     The <see cref="PipelineRasterizerState" />.
        /// </summary>
        [FieldOffset(408)]
        public PipelineRasterizerState Rasterizer;

        // TODO: Trace hooks
        [FieldOffset(440)]
        internal IntPtr Label;

        /// <summary>
        ///     A guard against garbage data; used to know if the structure has been initialized correctly.
        /// </summary>
        [FieldOffset(0)]
        internal uint _startCanary;

        /// <summary>
        ///     A guard against garbage data; used to know if the structure has been initialized correctly.
        /// </summary>
        [FieldOffset(448)]
        internal uint _endCanary;
    }
}
