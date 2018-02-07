﻿
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_AudioLowPassFilter_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AudioLowPassFilter);
            args = new Type[]{};
            method = type.GetMethod("get_cutoffFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cutoffFrequency_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_cutoffFrequency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cutoffFrequency_1);
            args = new Type[]{};
            method = type.GetMethod("get_customCutoffCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customCutoffCurve_2);
            args = new Type[]{typeof(UnityEngine.AnimationCurve)};
            method = type.GetMethod("set_customCutoffCurve", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_customCutoffCurve_3);
            args = new Type[]{};
            method = type.GetMethod("get_lowpassResonanceQ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lowpassResonanceQ_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lowpassResonanceQ", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lowpassResonanceQ_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AudioLowPassFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AudioLowPassFilter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_cutoffFrequency_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cutoffFrequency;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_cutoffFrequency_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cutoffFrequency = value;

            return __ret;
        }

        static StackObject* get_customCutoffCurve_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customCutoffCurve;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_customCutoffCurve_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve value = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.customCutoffCurve = value;

            return __ret;
        }

        static StackObject* get_lowpassResonanceQ_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lowpassResonanceQ;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lowpassResonanceQ_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AudioLowPassFilter instance_of_this_method;
            instance_of_this_method = (UnityEngine.AudioLowPassFilter)typeof(UnityEngine.AudioLowPassFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.lowpassResonanceQ = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AudioLowPassFilter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}