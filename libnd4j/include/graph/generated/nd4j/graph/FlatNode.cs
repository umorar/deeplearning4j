// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct FlatNode : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static FlatNode GetRootAsFlatNode(ByteBuffer _bb) { return GetRootAsFlatNode(_bb, new FlatNode()); }
  public static FlatNode GetRootAsFlatNode(ByteBuffer _bb, FlatNode obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public FlatNode __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public OpType OpType { get { int o = __p.__offset(8); return o != 0 ? (OpType)__p.bb.GetSbyte(o + __p.bb_pos) : OpType.TRANSFORM; } }
  public long OpNum { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatProperties? Properties(int j) { int o = __p.__offset(12); return o != 0 ? (FlatProperties?)(new FlatProperties()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PropertiesLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Input(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InputLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetInputBytes() { return __p.__vector_as_arraysegment(14); }
  public IntPair? InputPaired(int j) { int o = __p.__offset(16); return o != 0 ? (IntPair?)(new IntPair()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int InputPairedLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public DataType DataType { get { int o = __p.__offset(18); return o != 0 ? (DataType)__p.bb.GetSbyte(o + __p.bb_pos) : DataType.INHERIT; } }
  public int Output(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OutputLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetOutputBytes() { return __p.__vector_as_arraysegment(20); }
  public double ExtraParams(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int ExtraParamsLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetExtraParamsBytes() { return __p.__vector_as_arraysegment(22); }
  public long ExtraInteger(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraIntegerLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetExtraIntegerBytes() { return __p.__vector_as_arraysegment(24); }
  public int Dimensions(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DimensionsLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDimensionsBytes() { return __p.__vector_as_arraysegment(26); }
  public int Device { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Scalar { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int ScopeId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ScopeName { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetScopeNameBytes() { return __p.__vector_as_arraysegment(34); }
  public string OutputNames(int j) { int o = __p.__offset(36); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int OutputNamesLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string OpName { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetOpNameBytes() { return __p.__vector_as_arraysegment(38); }

  public static Offset<FlatNode> CreateFlatNode(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      OpType opType = OpType.TRANSFORM,
      long opNum = 0,
      VectorOffset propertiesOffset = default(VectorOffset),
      VectorOffset inputOffset = default(VectorOffset),
      VectorOffset inputPairedOffset = default(VectorOffset),
      DataType dataType = DataType.INHERIT,
      VectorOffset outputOffset = default(VectorOffset),
      VectorOffset extraParamsOffset = default(VectorOffset),
      VectorOffset extraIntegerOffset = default(VectorOffset),
      VectorOffset dimensionsOffset = default(VectorOffset),
      int device = 0,
      float scalar = 0.0f,
      int scope_id = 0,
      StringOffset scope_nameOffset = default(StringOffset),
      VectorOffset outputNamesOffset = default(VectorOffset),
      StringOffset opNameOffset = default(StringOffset)) {
    builder.StartObject(18);
    FlatNode.AddOpNum(builder, opNum);
    FlatNode.AddOpName(builder, opNameOffset);
    FlatNode.AddOutputNames(builder, outputNamesOffset);
    FlatNode.AddScopeName(builder, scope_nameOffset);
    FlatNode.AddScopeId(builder, scope_id);
    FlatNode.AddScalar(builder, scalar);
    FlatNode.AddDevice(builder, device);
    FlatNode.AddDimensions(builder, dimensionsOffset);
    FlatNode.AddExtraInteger(builder, extraIntegerOffset);
    FlatNode.AddExtraParams(builder, extraParamsOffset);
    FlatNode.AddOutput(builder, outputOffset);
    FlatNode.AddInputPaired(builder, inputPairedOffset);
    FlatNode.AddInput(builder, inputOffset);
    FlatNode.AddProperties(builder, propertiesOffset);
    FlatNode.AddName(builder, nameOffset);
    FlatNode.AddId(builder, id);
    FlatNode.AddDataType(builder, dataType);
    FlatNode.AddOpType(builder, opType);
    return FlatNode.EndFlatNode(builder);
  }

  public static void StartFlatNode(FlatBufferBuilder builder) { builder.StartObject(18); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddOpType(FlatBufferBuilder builder, OpType opType) { builder.AddSbyte(2, (sbyte)opType, 0); }
  public static void AddOpNum(FlatBufferBuilder builder, long opNum) { builder.AddLong(3, opNum, 0); }
  public static void AddProperties(FlatBufferBuilder builder, VectorOffset propertiesOffset) { builder.AddOffset(4, propertiesOffset.Value, 0); }
  public static VectorOffset CreatePropertiesVector(FlatBufferBuilder builder, Offset<FlatProperties>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartPropertiesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInput(FlatBufferBuilder builder, VectorOffset inputOffset) { builder.AddOffset(5, inputOffset.Value, 0); }
  public static VectorOffset CreateInputVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartInputVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInputPaired(FlatBufferBuilder builder, VectorOffset inputPairedOffset) { builder.AddOffset(6, inputPairedOffset.Value, 0); }
  public static VectorOffset CreateInputPairedVector(FlatBufferBuilder builder, Offset<IntPair>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInputPairedVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDataType(FlatBufferBuilder builder, DataType dataType) { builder.AddSbyte(7, (sbyte)dataType, 0); }
  public static void AddOutput(FlatBufferBuilder builder, VectorOffset outputOffset) { builder.AddOffset(8, outputOffset.Value, 0); }
  public static VectorOffset CreateOutputVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOutputVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraParams(FlatBufferBuilder builder, VectorOffset extraParamsOffset) { builder.AddOffset(9, extraParamsOffset.Value, 0); }
  public static VectorOffset CreateExtraParamsVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static void StartExtraParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExtraInteger(FlatBufferBuilder builder, VectorOffset extraIntegerOffset) { builder.AddOffset(10, extraIntegerOffset.Value, 0); }
  public static VectorOffset CreateExtraIntegerVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartExtraIntegerVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDimensions(FlatBufferBuilder builder, VectorOffset dimensionsOffset) { builder.AddOffset(11, dimensionsOffset.Value, 0); }
  public static VectorOffset CreateDimensionsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDimensionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDevice(FlatBufferBuilder builder, int device) { builder.AddInt(12, device, 0); }
  public static void AddScalar(FlatBufferBuilder builder, float scalar) { builder.AddFloat(13, scalar, 0.0f); }
  public static void AddScopeId(FlatBufferBuilder builder, int scopeId) { builder.AddInt(14, scopeId, 0); }
  public static void AddScopeName(FlatBufferBuilder builder, StringOffset scopeNameOffset) { builder.AddOffset(15, scopeNameOffset.Value, 0); }
  public static void AddOutputNames(FlatBufferBuilder builder, VectorOffset outputNamesOffset) { builder.AddOffset(16, outputNamesOffset.Value, 0); }
  public static VectorOffset CreateOutputNamesVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartOutputNamesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpName(FlatBufferBuilder builder, StringOffset opNameOffset) { builder.AddOffset(17, opNameOffset.Value, 0); }
  public static Offset<FlatNode> EndFlatNode(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FlatNode>(o);
  }
  public static void FinishFlatNodeBuffer(FlatBufferBuilder builder, Offset<FlatNode> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFlatNodeBuffer(FlatBufferBuilder builder, Offset<FlatNode> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}