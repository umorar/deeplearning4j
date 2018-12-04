// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct FlatVariable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static FlatVariable GetRootAsFlatVariable(ByteBuffer _bb) { return GetRootAsFlatVariable(_bb, new FlatVariable()); }
  public static FlatVariable GetRootAsFlatVariable(ByteBuffer _bb, FlatVariable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public FlatVariable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public IntPair? Id { get { int o = __p.__offset(4); return o != 0 ? (IntPair?)(new IntPair()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public long Shape(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ShapeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetShapeBytes() { return __p.__vector_as_arraysegment(8); }
  public FlatArray? Ndarray { get { int o = __p.__offset(10); return o != 0 ? (FlatArray?)(new FlatArray()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public int Device { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatVariable> CreateFlatVariable(FlatBufferBuilder builder,
      Offset<IntPair> idOffset = default(Offset<IntPair>),
      StringOffset nameOffset = default(StringOffset),
      VectorOffset shapeOffset = default(VectorOffset),
      Offset<FlatArray> ndarrayOffset = default(Offset<FlatArray>),
      int device = 0) {
    builder.StartObject(5);
    FlatVariable.AddDevice(builder, device);
    FlatVariable.AddNdarray(builder, ndarrayOffset);
    FlatVariable.AddShape(builder, shapeOffset);
    FlatVariable.AddName(builder, nameOffset);
    FlatVariable.AddId(builder, idOffset);
    return FlatVariable.EndFlatVariable(builder);
  }

  public static void StartFlatVariable(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, Offset<IntPair> idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddShape(FlatBufferBuilder builder, VectorOffset shapeOffset) { builder.AddOffset(2, shapeOffset.Value, 0); }
  public static VectorOffset CreateShapeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartShapeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddNdarray(FlatBufferBuilder builder, Offset<FlatArray> ndarrayOffset) { builder.AddOffset(3, ndarrayOffset.Value, 0); }
  public static void AddDevice(FlatBufferBuilder builder, int device) { builder.AddInt(4, device, 0); }
  public static Offset<FlatVariable> EndFlatVariable(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FlatVariable>(o);
  }
  public static void FinishFlatVariableBuffer(FlatBufferBuilder builder, Offset<FlatVariable> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFlatVariableBuffer(FlatBufferBuilder builder, Offset<FlatVariable> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
