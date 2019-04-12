/*
* MATLAB Compiler: 7.0.1 (R2019a)
* Date: Wed Apr 10 22:52:52 2019
* Arguments:
* "-B""macro_default""-W""dotnet:IMFDalgorithm,ClassIMFD,4.0,private""-T""link:lib""-d""E:
* \Users\sunce\Documents\MATLAB\Examples\R2019a\images\IMFD3\IMFDalgorithm\for_testing""-v
* ""class{ClassIMFD:E:\Users\sunce\Documents\MATLAB\Examples\R2019a\images\IMFD3\IMFDalgor
* ithm.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace IMFDalgorithm
{

  /// <summary>
  /// The ClassIMFD class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// E:\Users\sunce\Documents\MATLAB\Examples\R2019a\images\IMFD3\IMFDalgorithm.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class ClassIMFD : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static ClassIMFD()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "IMFDalgorithm.ctf";

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
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the ClassIMFD class.
    /// </summary>
    public ClassIMFD()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~ClassIMFD()
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
    /// Provides a void output, 0-input MWArrayinterface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    ///
    public void IMFDalgorithm()
    {
      mcr.EvaluateFunction(0, "IMFDalgorithm", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="sourceImgPath">Input argument #1</param>
    ///
    public void IMFDalgorithm(MWArray sourceImgPath)
    {
      mcr.EvaluateFunction(0, "IMFDalgorithm", sourceImgPath);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    ///
    public void IMFDalgorithm(MWArray sourceImgPath, MWArray targetImgPath)
    {
      mcr.EvaluateFunction(0, "IMFDalgorithm", sourceImgPath, targetImgPath);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    /// <param name="Nframes">Input argument #3</param>
    ///
    public void IMFDalgorithm(MWArray sourceImgPath, MWArray targetImgPath, MWArray 
                        Nframes)
    {
      mcr.EvaluateFunction(0, "IMFDalgorithm", sourceImgPath, targetImgPath, Nframes);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    /// <param name="Nframes">Input argument #3</param>
    /// <param name="delay">Input argument #4</param>
    ///
    public void IMFDalgorithm(MWArray sourceImgPath, MWArray targetImgPath, MWArray 
                        Nframes, MWArray delay)
    {
      mcr.EvaluateFunction(0, "IMFDalgorithm", sourceImgPath, targetImgPath, Nframes, delay);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] IMFDalgorithm(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "IMFDalgorithm", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] IMFDalgorithm(int numArgsOut, MWArray sourceImgPath)
    {
      return mcr.EvaluateFunction(numArgsOut, "IMFDalgorithm", sourceImgPath);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] IMFDalgorithm(int numArgsOut, MWArray sourceImgPath, MWArray 
                             targetImgPath)
    {
      return mcr.EvaluateFunction(numArgsOut, "IMFDalgorithm", sourceImgPath, targetImgPath);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    /// <param name="Nframes">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] IMFDalgorithm(int numArgsOut, MWArray sourceImgPath, MWArray 
                             targetImgPath, MWArray Nframes)
    {
      return mcr.EvaluateFunction(numArgsOut, "IMFDalgorithm", sourceImgPath, targetImgPath, Nframes);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the IMFDalgorithm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Load the image
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="sourceImgPath">Input argument #1</param>
    /// <param name="targetImgPath">Input argument #2</param>
    /// <param name="Nframes">Input argument #3</param>
    /// <param name="delay">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] IMFDalgorithm(int numArgsOut, MWArray sourceImgPath, MWArray 
                             targetImgPath, MWArray Nframes, MWArray delay)
    {
      return mcr.EvaluateFunction(numArgsOut, "IMFDalgorithm", sourceImgPath, targetImgPath, Nframes, delay);
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

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
