/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Thu Mar 19 22:33:48 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:Auseft,Demo,0.0,private" "-d" "D:\Program
* Files\MATLAB\work\Auseft\Auseft\src" "-T" "link:lib" "-v" "class{Demo:D:\Program
* Files\MATLAB\work\coalMonth.m,D:\Program Files\MATLAB\work\coalyear.m,D:\Program
* Files\MATLAB\work\mixture2.m,D:\Program Files\MATLAB\work\mixture3.m,D:\Program
* Files\MATLAB\work\Procurement.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Auseft
{
  /// <summary>
  /// The Demo class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// D:\Program Files\MATLAB\work\coalMonth.m
  /// <newpara></newpara>
  /// D:\Program Files\MATLAB\work\coalyear.m
  /// <newpara></newpara>
  /// D:\Program Files\MATLAB\work\mixture2.m
  /// <newpara></newpara>
  /// D:\Program Files\MATLAB\work\mixture3.m
  /// <newpara></newpara>
  /// D:\Program Files\MATLAB\work\Procurement.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Demo : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static Demo()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_Auseft_name_data + ".ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR(MCRComponentState.MCC_Auseft_name_data,
                       MCRComponentState.MCC_Auseft_root_data,
                       MCRComponentState.MCC_Auseft_public_data,
                       MCRComponentState.MCC_Auseft_session_data,
                       MCRComponentState.MCC_Auseft_matlabpath_data,
                       MCRComponentState.MCC_Auseft_classpath_data,
                       MCRComponentState.MCC_Auseft_libpath_data,
                       MCRComponentState.MCC_Auseft_mcr_application_options,
                       MCRComponentState.MCC_Auseft_mcr_runtime_options,
                       MCRComponentState.MCC_Auseft_mcr_pref_dir,
                       MCRComponentState.MCC_Auseft_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Demo class.
    /// </summary>
    public Demo()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Demo()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth()
    {
      return mcr.EvaluateFunction("coalMonth", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M)
    {
      return mcr.EvaluateFunction("coalMonth", M);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction("coalMonth", M, V);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D, 
                       MWArray p1)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D, p1);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D, 
                       MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D, p1, p2);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D, 
                       MWArray p1, MWArray p2, MWArray p3)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D, p1, p2, p3);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <param name="p4">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D, 
                       MWArray p1, MWArray p2, MWArray p3, MWArray p4)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D, p1, p2, p3, p4);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <param name="p4">Input argument #9</param>
    /// <param name="p5">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalMonth(MWArray M, MWArray V, MWArray V0, MWArray Vs, MWArray D, 
                       MWArray p1, MWArray p2, MWArray p3, MWArray p4, MWArray p5)
    {
      return mcr.EvaluateFunction("coalMonth", M, V, V0, Vs, D, p1, p2, p3, p4, p5);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D, MWArray p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D, p1);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D, MWArray p1, MWArray p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D, p1, p2);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D, MWArray p1, MWArray p2, MWArray p3)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D, p1, p2, p3);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <param name="p4">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D, MWArray p1, MWArray p2, MWArray p3, MWArray p4)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D, p1, p2, p3, p4);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the coalMonth M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="M">Input argument #1</param>
    /// <param name="V">Input argument #2</param>
    /// <param name="V0">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="p2">Input argument #7</param>
    /// <param name="p3">Input argument #8</param>
    /// <param name="p4">Input argument #9</param>
    /// <param name="p5">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalMonth(int numArgsOut, MWArray M, MWArray V, MWArray V0, MWArray 
                         Vs, MWArray D, MWArray p1, MWArray p2, MWArray p3, MWArray p4, 
                         MWArray p5)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalMonth", M, V, V0, Vs, D, p1, p2, p3, p4, p5);
    }


    /// <summary>
    /// Provides an interface for the coalMonth function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void coalMonth(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("coalMonth", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear()
    {
      return mcr.EvaluateFunction("coalyear", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0)
    {
      return mcr.EvaluateFunction("coalyear", V0);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M)
    {
      return mcr.EvaluateFunction("coalyear", V0, M);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8);
    }


    /// <summary>
    /// Provides a single output, 22-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9);
    }


    /// <summary>
    /// Provides a single output, 23-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9);
    }


    /// <summary>
    /// Provides a single output, 24-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10);
    }


    /// <summary>
    /// Provides a single output, 25-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10, MWArray s10)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10);
    }


    /// <summary>
    /// Provides a single output, 26-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10, MWArray s10, MWArray p11)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11);
    }


    /// <summary>
    /// Provides a single output, 27-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10, MWArray s10, MWArray p11, MWArray s11)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11);
    }


    /// <summary>
    /// Provides a single output, 28-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <param name="p12">Input argument #28</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10, MWArray s10, MWArray p11, MWArray s11, 
                      MWArray p12)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11, p12);
    }


    /// <summary>
    /// Provides a single output, 29-input MWArrayinterface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <param name="p12">Input argument #28</param>
    /// <param name="s12">Input argument #29</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray coalyear(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                      MWArray p1, MWArray s1, MWArray p2, MWArray s2, MWArray p3, MWArray 
                      s3, MWArray p4, MWArray s4, MWArray p5, MWArray s5, MWArray p6, 
                      MWArray s6, MWArray p7, MWArray s7, MWArray p8, MWArray s8, MWArray 
                      p9, MWArray s9, MWArray p10, MWArray s10, MWArray p11, MWArray s11, 
                      MWArray p12, MWArray s12)
    {
      return mcr.EvaluateFunction("coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11, p12, s12);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8);
    }


    /// <summary>
    /// Provides the standard 22-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9);
    }


    /// <summary>
    /// Provides the standard 23-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9);
    }


    /// <summary>
    /// Provides the standard 24-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10);
    }


    /// <summary>
    /// Provides the standard 25-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10, 
                        MWArray s10)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10);
    }


    /// <summary>
    /// Provides the standard 26-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10, 
                        MWArray s10, MWArray p11)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11);
    }


    /// <summary>
    /// Provides the standard 27-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10, 
                        MWArray s10, MWArray p11, MWArray s11)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11);
    }


    /// <summary>
    /// Provides the standard 28-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <param name="p12">Input argument #28</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10, 
                        MWArray s10, MWArray p11, MWArray s11, MWArray p12)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11, p12);
    }


    /// <summary>
    /// Provides the standard 29-input MWArray interface to the coalyear M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="p1">Input argument #6</param>
    /// <param name="s1">Input argument #7</param>
    /// <param name="p2">Input argument #8</param>
    /// <param name="s2">Input argument #9</param>
    /// <param name="p3">Input argument #10</param>
    /// <param name="s3">Input argument #11</param>
    /// <param name="p4">Input argument #12</param>
    /// <param name="s4">Input argument #13</param>
    /// <param name="p5">Input argument #14</param>
    /// <param name="s5">Input argument #15</param>
    /// <param name="p6">Input argument #16</param>
    /// <param name="s6">Input argument #17</param>
    /// <param name="p7">Input argument #18</param>
    /// <param name="s7">Input argument #19</param>
    /// <param name="p8">Input argument #20</param>
    /// <param name="s8">Input argument #21</param>
    /// <param name="p9">Input argument #22</param>
    /// <param name="s9">Input argument #23</param>
    /// <param name="p10">Input argument #24</param>
    /// <param name="s10">Input argument #25</param>
    /// <param name="p11">Input argument #26</param>
    /// <param name="s11">Input argument #27</param>
    /// <param name="p12">Input argument #28</param>
    /// <param name="s12">Input argument #29</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] coalyear(int numArgsOut, MWArray V0, MWArray M, MWArray V, MWArray 
                        Vs, MWArray D, MWArray p1, MWArray s1, MWArray p2, MWArray s2, 
                        MWArray p3, MWArray s3, MWArray p4, MWArray s4, MWArray p5, 
                        MWArray s5, MWArray p6, MWArray s6, MWArray p7, MWArray s7, 
                        MWArray p8, MWArray s8, MWArray p9, MWArray s9, MWArray p10, 
                        MWArray s10, MWArray p11, MWArray s11, MWArray p12, MWArray s12)
    {
      return mcr.EvaluateFunction(numArgsOut, "coalyear", V0, M, V, Vs, D, p1, s1, p2, s2, p3, s3, p4, s4, p5, s5, p6, s6, p7, s7, p8, s8, p9, s9, p10, s10, p11, s11, p12, s12);
    }


    /// <summary>
    /// Provides an interface for the coalyear function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// C=[400;400;400;500;434;445;446;443;449;450;436;434];
    /// 月最大采购量（吨）：M
    /// 安全库存(吨)：Vs
    /// 实际库存（吨）：V
    /// 最大库存：V0
    /// 月耗煤量（吨）：D
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void coalyear(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("coalyear", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2()
    {
      return mcr.EvaluateFunction("mixture2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1)
    {
      return mcr.EvaluateFunction("mixture2", A1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV, MWArray MinV)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, 
                      MWArray MinQ)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <param name="P1">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, 
                      MWArray MinQ, MWArray P1)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <param name="P1">Input argument #17</param>
    /// <param name="P2">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture2(MWArray A1, MWArray A2, MWArray M1, MWArray M2, MWArray V1, 
                      MWArray V2, MWArray S1, MWArray S2, MWArray Q1, MWArray Q2, MWArray 
                      MaxA, MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, 
                      MWArray MinQ, MWArray P1, MWArray P2)
    {
      return mcr.EvaluateFunction("mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <param name="P1">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ, MWArray P1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the mixture2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="M1">Input argument #3</param>
    /// <param name="M2">Input argument #4</param>
    /// <param name="V1">Input argument #5</param>
    /// <param name="V2">Input argument #6</param>
    /// <param name="S1">Input argument #7</param>
    /// <param name="S2">Input argument #8</param>
    /// <param name="Q1">Input argument #9</param>
    /// <param name="Q2">Input argument #10</param>
    /// <param name="MaxA">Input argument #11</param>
    /// <param name="MaxM">Input argument #12</param>
    /// <param name="MaxV">Input argument #13</param>
    /// <param name="MinV">Input argument #14</param>
    /// <param name="MaxS">Input argument #15</param>
    /// <param name="MinQ">Input argument #16</param>
    /// <param name="P1">Input argument #17</param>
    /// <param name="P2">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture2(int numArgsOut, MWArray A1, MWArray A2, MWArray M1, MWArray 
                        M2, MWArray V1, MWArray V2, MWArray S1, MWArray S2, MWArray Q1, 
                        MWArray Q2, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ, MWArray P1, MWArray P2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture2", A1, A2, M1, M2, V1, V2, S1, S2, Q1, Q2, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2);
    }


    /// <summary>
    /// Provides an interface for the mixture2 function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void mixture2(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mixture2", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3()
    {
      return mcr.EvaluateFunction("mixture3", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1)
    {
      return mcr.EvaluateFunction("mixture3", A1);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, MWArray 
                      MinQ)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ);
    }


    /// <summary>
    /// Provides a single output, 22-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, MWArray 
                      MinQ, MWArray P1)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1);
    }


    /// <summary>
    /// Provides a single output, 23-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <param name="P2">Input argument #23</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, MWArray 
                      MinQ, MWArray P1, MWArray P2)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2);
    }


    /// <summary>
    /// Provides a single output, 24-input MWArrayinterface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <param name="P2">Input argument #23</param>
    /// <param name="P3">Input argument #24</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mixture3(MWArray A1, MWArray A2, MWArray A3, MWArray M1, MWArray M2, 
                      MWArray M3, MWArray V1, MWArray V2, MWArray V3, MWArray S1, MWArray 
                      S2, MWArray S3, MWArray Q1, MWArray Q2, MWArray Q3, MWArray MaxA, 
                      MWArray MaxM, MWArray MaxV, MWArray MinV, MWArray MaxS, MWArray 
                      MinQ, MWArray P1, MWArray P2, MWArray P3)
    {
      return mcr.EvaluateFunction("mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2, P3);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ);
    }


    /// <summary>
    /// Provides the standard 22-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ, MWArray P1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1);
    }


    /// <summary>
    /// Provides the standard 23-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <param name="P2">Input argument #23</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ, MWArray P1, MWArray P2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2);
    }


    /// <summary>
    /// Provides the standard 24-input MWArray interface to the mixture3 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A1">Input argument #1</param>
    /// <param name="A2">Input argument #2</param>
    /// <param name="A3">Input argument #3</param>
    /// <param name="M1">Input argument #4</param>
    /// <param name="M2">Input argument #5</param>
    /// <param name="M3">Input argument #6</param>
    /// <param name="V1">Input argument #7</param>
    /// <param name="V2">Input argument #8</param>
    /// <param name="V3">Input argument #9</param>
    /// <param name="S1">Input argument #10</param>
    /// <param name="S2">Input argument #11</param>
    /// <param name="S3">Input argument #12</param>
    /// <param name="Q1">Input argument #13</param>
    /// <param name="Q2">Input argument #14</param>
    /// <param name="Q3">Input argument #15</param>
    /// <param name="MaxA">Input argument #16</param>
    /// <param name="MaxM">Input argument #17</param>
    /// <param name="MaxV">Input argument #18</param>
    /// <param name="MinV">Input argument #19</param>
    /// <param name="MaxS">Input argument #20</param>
    /// <param name="MinQ">Input argument #21</param>
    /// <param name="P1">Input argument #22</param>
    /// <param name="P2">Input argument #23</param>
    /// <param name="P3">Input argument #24</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mixture3(int numArgsOut, MWArray A1, MWArray A2, MWArray A3, MWArray 
                        M1, MWArray M2, MWArray M3, MWArray V1, MWArray V2, MWArray V3, 
                        MWArray S1, MWArray S2, MWArray S3, MWArray Q1, MWArray Q2, 
                        MWArray Q3, MWArray MaxA, MWArray MaxM, MWArray MaxV, MWArray 
                        MinV, MWArray MaxS, MWArray MinQ, MWArray P1, MWArray P2, MWArray 
                        P3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mixture3", A1, A2, A3, M1, M2, M3, V1, V2, V3, S1, S2, S3, Q1, Q2, Q3, MaxA, MaxM, MaxV, MinV, MaxS, MinQ, P1, P2, P3);
    }


    /// <summary>
    /// Provides an interface for the mixture3 function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void mixture3(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mixture3", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement()
    {
      return mcr.EvaluateFunction("Procurement", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0)
    {
      return mcr.EvaluateFunction("Procurement", V0);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M)
    {
      return mcr.EvaluateFunction("Procurement", V0, M);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31);
    }


    /// <summary>
    /// Provides a single output, 22-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32);
    }


    /// <summary>
    /// Provides a single output, 23-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33);
    }


    /// <summary>
    /// Provides a single output, 24-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34);
    }


    /// <summary>
    /// Provides a single output, 25-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35);
    }


    /// <summary>
    /// Provides a single output, 26-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41);
    }


    /// <summary>
    /// Provides a single output, 27-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42);
    }


    /// <summary>
    /// Provides a single output, 28-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43);
    }


    /// <summary>
    /// Provides a single output, 29-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44);
    }


    /// <summary>
    /// Provides a single output, 30-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45);
    }


    /// <summary>
    /// Provides a single output, 31-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51);
    }


    /// <summary>
    /// Provides a single output, 32-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52);
    }


    /// <summary>
    /// Provides a single output, 33-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53);
    }


    /// <summary>
    /// Provides a single output, 34-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54);
    }


    /// <summary>
    /// Provides a single output, 35-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55);
    }


    /// <summary>
    /// Provides a single output, 36-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55, MWArray S1)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1);
    }


    /// <summary>
    /// Provides a single output, 37-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55, MWArray S1, MWArray S2)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2);
    }


    /// <summary>
    /// Provides a single output, 38-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55, MWArray S1, MWArray S2, MWArray S3)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3);
    }


    /// <summary>
    /// Provides a single output, 39-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <param name="S4">Input argument #39</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55, MWArray S1, MWArray S2, MWArray S3, MWArray S4)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3, S4);
    }


    /// <summary>
    /// Provides a single output, 40-input MWArrayinterface to the Procurement
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <param name="S4">Input argument #39</param>
    /// <param name="S5">Input argument #40</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Procurement(MWArray V0, MWArray M, MWArray V, MWArray Vs, MWArray D, 
                         MWArray MAXXM1, MWArray MAXXM2, MWArray MAXXM3, MWArray MAXXM4, 
                         MWArray MAXXM5, MWArray P11, MWArray P12, MWArray P13, MWArray 
                         P14, MWArray P15, MWArray P21, MWArray P22, MWArray P23, MWArray 
                         P24, MWArray P25, MWArray P31, MWArray P32, MWArray P33, MWArray 
                         P34, MWArray P35, MWArray P41, MWArray P42, MWArray P43, MWArray 
                         P44, MWArray P45, MWArray P51, MWArray P52, MWArray P53, MWArray 
                         P54, MWArray P55, MWArray S1, MWArray S2, MWArray S3, MWArray 
                         S4, MWArray S5)
    {
      return mcr.EvaluateFunction("Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3, S4, S5);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31);
    }


    /// <summary>
    /// Provides the standard 22-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32);
    }


    /// <summary>
    /// Provides the standard 23-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33);
    }


    /// <summary>
    /// Provides the standard 24-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34);
    }


    /// <summary>
    /// Provides the standard 25-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35);
    }


    /// <summary>
    /// Provides the standard 26-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41);
    }


    /// <summary>
    /// Provides the standard 27-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42);
    }


    /// <summary>
    /// Provides the standard 28-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43);
    }


    /// <summary>
    /// Provides the standard 29-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44);
    }


    /// <summary>
    /// Provides the standard 30-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45);
    }


    /// <summary>
    /// Provides the standard 31-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51);
    }


    /// <summary>
    /// Provides the standard 32-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52);
    }


    /// <summary>
    /// Provides the standard 33-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53);
    }


    /// <summary>
    /// Provides the standard 34-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54);
    }


    /// <summary>
    /// Provides the standard 35-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55);
    }


    /// <summary>
    /// Provides the standard 36-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55, MWArray S1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1);
    }


    /// <summary>
    /// Provides the standard 37-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55, MWArray S1, MWArray S2)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2);
    }


    /// <summary>
    /// Provides the standard 38-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55, MWArray S1, MWArray S2, MWArray S3)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3);
    }


    /// <summary>
    /// Provides the standard 39-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <param name="S4">Input argument #39</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55, MWArray S1, MWArray S2, MWArray S3, MWArray S4)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3, S4);
    }


    /// <summary>
    /// Provides the standard 40-input MWArray interface to the Procurement M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="V0">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="V">Input argument #3</param>
    /// <param name="Vs">Input argument #4</param>
    /// <param name="D">Input argument #5</param>
    /// <param name="MAXXM1">Input argument #6</param>
    /// <param name="MAXXM2">Input argument #7</param>
    /// <param name="MAXXM3">Input argument #8</param>
    /// <param name="MAXXM4">Input argument #9</param>
    /// <param name="MAXXM5">Input argument #10</param>
    /// <param name="P11">Input argument #11</param>
    /// <param name="P12">Input argument #12</param>
    /// <param name="P13">Input argument #13</param>
    /// <param name="P14">Input argument #14</param>
    /// <param name="P15">Input argument #15</param>
    /// <param name="P21">Input argument #16</param>
    /// <param name="P22">Input argument #17</param>
    /// <param name="P23">Input argument #18</param>
    /// <param name="P24">Input argument #19</param>
    /// <param name="P25">Input argument #20</param>
    /// <param name="P31">Input argument #21</param>
    /// <param name="P32">Input argument #22</param>
    /// <param name="P33">Input argument #23</param>
    /// <param name="P34">Input argument #24</param>
    /// <param name="P35">Input argument #25</param>
    /// <param name="P41">Input argument #26</param>
    /// <param name="P42">Input argument #27</param>
    /// <param name="P43">Input argument #28</param>
    /// <param name="P44">Input argument #29</param>
    /// <param name="P45">Input argument #30</param>
    /// <param name="P51">Input argument #31</param>
    /// <param name="P52">Input argument #32</param>
    /// <param name="P53">Input argument #33</param>
    /// <param name="P54">Input argument #34</param>
    /// <param name="P55">Input argument #35</param>
    /// <param name="S1">Input argument #36</param>
    /// <param name="S2">Input argument #37</param>
    /// <param name="S3">Input argument #38</param>
    /// <param name="S4">Input argument #39</param>
    /// <param name="S5">Input argument #40</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] Procurement(int numArgsOut, MWArray V0, MWArray M, MWArray V, 
                           MWArray Vs, MWArray D, MWArray MAXXM1, MWArray MAXXM2, MWArray 
                           MAXXM3, MWArray MAXXM4, MWArray MAXXM5, MWArray P11, MWArray 
                           P12, MWArray P13, MWArray P14, MWArray P15, MWArray P21, 
                           MWArray P22, MWArray P23, MWArray P24, MWArray P25, MWArray 
                           P31, MWArray P32, MWArray P33, MWArray P34, MWArray P35, 
                           MWArray P41, MWArray P42, MWArray P43, MWArray P44, MWArray 
                           P45, MWArray P51, MWArray P52, MWArray P53, MWArray P54, 
                           MWArray P55, MWArray S1, MWArray S2, MWArray S3, MWArray S4, 
                           MWArray S5)
    {
      return mcr.EvaluateFunction(numArgsOut, "Procurement", V0, M, V, Vs, D, MAXXM1, MAXXM2, MAXXM3, MAXXM4, MAXXM5, P11, P12, P13, P14, P15, P21, P22, P23, P24, P25, P31, P32, P33, P34, P35, P41, P42, P43, P44, P45, P51, P52, P53, P54, P55, S1, S2, S3, S4, S5);
    }


    /// <summary>
    /// Provides an interface for the Procurement function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 五个煤种的在五周的依次价格：煤种1所有周的价格；...；煤种5所有周的价格；
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void Procurement(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Procurement", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
