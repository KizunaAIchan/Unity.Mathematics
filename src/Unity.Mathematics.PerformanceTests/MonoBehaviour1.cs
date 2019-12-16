﻿using System;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    public class TestConversions
    {
        [Test, Performance]
        public void QuaternionToFloat3x3()
        {
            var q1 = quaternion.identity;
            var f3x3 = new float3x3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3x3 = new float3x3(q1);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void QuaternionToRigidTransform()
        {
            var q1 = quaternion.identity;
            var r = RigidTransform.identity;
            var position = new float3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        r = new RigidTransform(q1, position);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float3x3ToQuaternion()
        {
            var q1 = new quaternion();
            var f3x3 = float3x3.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        q1 = new quaternion(f3x3);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4x4ToQuaternion()
        {
            var q1 = new quaternion();
            var f4x4 = float4x4.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        q1 = new quaternion(f4x4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4ToUint4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var u4 = new uint4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u4 = math.asuint(f4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Uint4ToFloat4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var u4 = new uint4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4 = math.asfloat(u4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4ToHalf4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var h4 = new half4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        h4 = new half4(f4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Half4ToFloat4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var h4 = new half4(math.half(1.0f), math.half(2.0f), math.half(3.0f), math.half(4.0f));

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4 = new float4(h4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }

    public class TestTrig
    {
        [Test, Performance]
        public void sincos4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var sin = new float4();
            var cos = new float4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f4, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos3()
        {
            var f3 = new float3(1.0f, 2.0f, 3.0f);
            var sin = new float3();
            var cos = new float3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f3, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos2()
        {
            var f2 = new float2(1.0f, 2.0f);
            var sin = new float2();
            var cos = new float2();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f2, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos()
        {
            var f = 1.0f;
            var sin = 0.0f;
            var cos = 0.0f;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }

    public class TestRandom
    {
        [Test, Performance]
        public void NextUInt()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void NextUInt2()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint2 u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt2();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void NextUInt3()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint3 u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt3();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }
}