﻿/*
 * The MIT License (MIT)
 * Copyright (c) 2014 Andrés Correa Casablanca
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/*
 * Contributors:
 *  - Andrés Correa Casablanca <castarco@gmail.com , castarco@litipk.com>
 */


namespace Litipk.ColorSharp
{
	namespace MatchingFunctions
	{
		/**
		 * This class will be a singleton
		 */
		sealed public class CIE1931XYZ1NmMatchingFunctionZ : RegularMatchingFunction
		{
			public static readonly CIE1931XYZ1NmMatchingFunctionZ Instance = new CIE1931XYZ1NmMatchingFunctionZ (
				380.0, new [] {
					0.006450001000,
					0.007083216000,
					0.007745488000,
					0.008501152000,
					0.009414544000,
					0.010549990000,
					0.011965800000,
					0.013655870000,
					0.015588050000,
					0.017730150000,
					0.020050010000,
					0.022511360000,
					0.025202880000,
					0.028279720000,
					0.031897040000,
					0.036210000000,
					0.041437710000,
					0.047503720000,
					0.054119880000,
					0.060998030000,
					0.067850010000,
					0.074486320000,
					0.081361560000,
					0.089153640000,
					0.098540480000,
					0.110200000000,
					0.124613300000,
					0.141701700000,
					0.161303500000,
					0.183256800000,
					0.207400000000,
					0.233692100000,
					0.262611400000,
					0.294774600000,
					0.330798500000,
					0.371300000000,
					0.416209100000,
					0.465464200000,
					0.519694800000,
					0.579530300000,
					0.645600000000,
					0.718483800000,
					0.796713300000,
					0.877845900000,
					0.959439000000,
					1.039050100000,
					1.115367300000,
					1.188497100000,
					1.258123300000,
					1.323929600000,
					1.385600000000,
					1.442635200000,
					1.494803500000,
					1.542190300000,
					1.584880700000,
					1.622960000000,
					1.656404800000,
					1.685295900000,
					1.709874500000,
					1.730382100000,
					1.747060000000,
					1.760044600000,
					1.769623300000,
					1.776263700000,
					1.780433400000,
					1.782600000000,
					1.782968200000,
					1.781699800000,
					1.779198200000,
					1.775867100000,
					1.772110000000,
					1.768258900000,
					1.764039000000,
					1.758943800000,
					1.752466300000,
					1.744100000000,
					1.733559500000,
					1.720858100000,
					1.705936900000,
					1.688737200000,
					1.669200000000,
					1.647528700000,
					1.623412700000,
					1.596022300000,
					1.564528000000,
					1.528100000000,
					1.486111400000,
					1.439521500000,
					1.389879900000,
					1.338736200000,
					1.287640000000,
					1.237422300000,
					1.187824300000,
					1.138761100000,
					1.090148000000,
					1.041900000000,
					0.994197600000,
					0.947347300000,
					0.901453100000,
					0.856619300000,
					0.812950100000,
					0.770517300000,
					0.729444800000,
					0.689913600000,
					0.652104900000,
					0.616200000000,
					0.582328600000,
					0.550416200000,
					0.520337600000,
					0.491967300000,
					0.465180000000,
					0.439924600000,
					0.416183600000,
					0.393882200000,
					0.372945900000,
					0.353300000000,
					0.334857800000,
					0.317552100000,
					0.301337500000,
					0.286168600000,
					0.272000000000,
					0.258817100000,
					0.246483800000,
					0.234771800000,
					0.223453300000,
					0.212300000000,
					0.201169200000,
					0.190119600000,
					0.179225400000,
					0.168560800000,
					0.158200000000,
					0.148138300000,
					0.138375800000,
					0.128994200000,
					0.120075100000,
					0.111700000000,
					0.103904800000,
					0.096667480000,
					0.089982720000,
					0.083845310000,
					0.078249990000,
					0.073208990000,
					0.068678160000,
					0.064567840000,
					0.060788350000,
					0.057250010000,
					0.053904350000,
					0.050746640000,
					0.047752760000,
					0.044898590000,
					0.042160000000,
					0.039507280000,
					0.036935640000,
					0.034458360000,
					0.032088720000,
					0.029840000000,
					0.027711810000,
					0.025694440000,
					0.023787160000,
					0.021989250000,
					0.020300000000,
					0.018718050000,
					0.017240360000,
					0.015863640000,
					0.014584610000,
					0.013400000000,
					0.012307230000,
					0.011301880000,
					0.010377920000,
					0.009529306000,
					0.008749999000,
					0.008035200000,
					0.007381600000,
					0.006785400000,
					0.006242800000,
					0.005749999000,
					0.005303600000,
					0.004899800000,
					0.004534200000,
					0.004202400000,
					0.003900000000,
					0.003623200000,
					0.003370600000,
					0.003141400000,
					0.002934800000,
					0.002749999000,
					0.002585200000,
					0.002438600000,
					0.002309400000,
					0.002196800000,
					0.002100000000,
					0.002017733000,
					0.001948200000,
					0.001889800000,
					0.001840933000,
					0.001800000000,
					0.001766267000,
					0.001737800000,
					0.001711200000,
					0.001683067000,
					0.001650001000,
					0.001610133000,
					0.001564400000,
					0.001513600000,
					0.001458533000,
					0.001400000000,
					0.001336667000,
					0.001270000000,
					0.001205000000,
					0.001146667000,
					0.001100000000,
					0.001068800000,
					0.001049400000,
					0.001035600000,
					0.001021200000,
					0.001000000000,
					0.000968640000,
					0.000929920000,
					0.000886880000,
					0.000842560000,
					0.000800000000,
					0.000760960000,
					0.000723680000,
					0.000685920000,
					0.000645440000,
					0.000600000000,
					0.000547866700,
					0.000491600000,
					0.000435400000,
					0.000383466700,
					0.000340000000,
					0.000307253300,
					0.000283160000,
					0.000265440000,
					0.000251813300,
					0.000240000000,
					0.000229546700,
					0.000220640000,
					0.000211960000,
					0.000202186700,
					0.000190000000,
					0.000174213300,
					0.000155640000,
					0.000135960000,
					0.000116853300,
					0.000100000000,
					0.000086133330,
					0.000074600000,
					0.000065000000,
					0.000056933330,
					0.000049999990,
					0.000044160000,
					0.000039480000,
					0.000035720000,
					0.000032640000,
					0.000030000000,
					0.000027653330,
					0.000025560000,
					0.000023640000,
					0.000021813330,
					0.000020000000,
					0.000018133330,
					0.000016200000,
					0.000014200000,
					0.000012133330,
					0.000010000000,
					0.000007733333,
					0.000005400000,
					0.000003200000,
					0.000001333333,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000,
					0.000000000000
				}, 1
			);

			/**
			 * We must seal this 
			 */
			CIE1931XYZ1NmMatchingFunctionZ (double minWaveLength, double[] amplitudes, double nmPerStep) : base(
				minWaveLength, amplitudes, nmPerStep
			) {}
		}
	}
}



