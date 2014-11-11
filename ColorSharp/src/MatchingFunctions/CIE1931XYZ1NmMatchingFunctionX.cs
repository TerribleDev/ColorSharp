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
		sealed public class CIE1931XYZ1NmMatchingFunctionX : RegularMatchingFunction
		{
			public static readonly CIE1931XYZ1NmMatchingFunctionX Instance = new CIE1931XYZ1NmMatchingFunctionX (
				380.0, new [] {
					0.001368000000,
					0.001502050000,
					0.001642328000,
					0.001802382000,
					0.001995757000,
					0.002236000000,
					0.002535385000,
					0.002892603000,
					0.003300829000,
					0.003753236000,
					0.004243000000,
					0.004762389000,
					0.005330048000,
					0.005978712000,
					0.006741117000,
					0.007650000000,
					0.008751373000,
					0.010028880000,
					0.011421700000,
					0.012869010000,
					0.014310000000,
					0.015704430000,
					0.017147440000,
					0.018781220000,
					0.020748010000,
					0.023190000000,
					0.026207360000,
					0.029782480000,
					0.033880920000,
					0.038468240000,
					0.043510000000,
					0.048995600000,
					0.055022600000,
					0.061718800000,
					0.069212000000,
					0.077630000000,
					0.086958110000,
					0.097176720000,
					0.108406300000,
					0.120767200000,
					0.134380000000,
					0.149358200000,
					0.165395700000,
					0.181983100000,
					0.198611000000,
					0.214770000000,
					0.230186800000,
					0.244879700000,
					0.258777300000,
					0.271807900000,
					0.283900000000,
					0.294943800000,
					0.304896500000,
					0.313787300000,
					0.321645400000,
					0.328500000000,
					0.334351300000,
					0.339210100000,
					0.343121300000,
					0.346129600000,
					0.348280000000,
					0.349599900000,
					0.350147400000,
					0.350013000000,
					0.349287000000,
					0.348060000000,
					0.346373300000,
					0.344262400000,
					0.341808800000,
					0.339094100000,
					0.336200000000,
					0.333197700000,
					0.330041100000,
					0.326635700000,
					0.322886800000,
					0.318700000000,
					0.314025100000,
					0.308884000000,
					0.303290400000,
					0.297257900000,
					0.290800000000,
					0.283970100000,
					0.276721400000,
					0.268917800000,
					0.260422700000,
					0.251100000000,
					0.240847500000,
					0.229851200000,
					0.218407200000,
					0.206811500000,
					0.195360000000,
					0.184213600000,
					0.173327300000,
					0.162688100000,
					0.152283300000,
					0.142100000000,
					0.132178600000,
					0.122569600000,
					0.113275200000,
					0.104297900000,
					0.095640000000,
					0.087299550000,
					0.079308040000,
					0.071717760000,
					0.064580990000,
					0.057950010000,
					0.051862110000,
					0.046281520000,
					0.041150880000,
					0.036412830000,
					0.032010000000,
					0.027917200000,
					0.024144400000,
					0.020687000000,
					0.017540400000,
					0.014700000000,
					0.012161790000,
					0.009919960000,
					0.007967240000,
					0.006296346000,
					0.004900000000,
					0.003777173000,
					0.002945320000,
					0.002424880000,
					0.002236293000,
					0.002400000000,
					0.002925520000,
					0.003836560000,
					0.005174840000,
					0.006982080000,
					0.009300000000,
					0.012149490000,
					0.015535880000,
					0.019477520000,
					0.023992770000,
					0.029100000000,
					0.034814850000,
					0.041120160000,
					0.047985040000,
					0.055378610000,
					0.063270000000,
					0.071635010000,
					0.080462240000,
					0.089739960000,
					0.099456450000,
					0.109600000000,
					0.120167400000,
					0.131114500000,
					0.142367900000,
					0.153854200000,
					0.165500000000,
					0.177257100000,
					0.189140000000,
					0.201169400000,
					0.213365800000,
					0.225749900000,
					0.238320900000,
					0.251066800000,
					0.263992200000,
					0.277101700000,
					0.290400000000,
					0.303891200000,
					0.317572600000,
					0.331438400000,
					0.345482800000,
					0.359700000000,
					0.374083900000,
					0.388639600000,
					0.403378400000,
					0.418311500000,
					0.433449900000,
					0.448795300000,
					0.464336000000,
					0.480064000000,
					0.495971300000,
					0.512050100000,
					0.528295900000,
					0.544691600000,
					0.561209400000,
					0.577821500000,
					0.594500000000,
					0.611220900000,
					0.627975800000,
					0.644760200000,
					0.661569700000,
					0.678400000000,
					0.695239200000,
					0.712058600000,
					0.728828400000,
					0.745518800000,
					0.762100000000,
					0.778543200000,
					0.794825600000,
					0.810926400000,
					0.826824800000,
					0.842500000000,
					0.857932500000,
					0.873081600000,
					0.887894400000,
					0.902318100000,
					0.916300000000,
					0.929799500000,
					0.942798400000,
					0.955277600000,
					0.967217900000,
					0.978600000000,
					0.989385600000,
					0.999548800000,
					1.009089200000,
					1.018006400000,
					1.026300000000,
					1.033982700000,
					1.040986000000,
					1.047188000000,
					1.052466700000,
					1.056700000000,
					1.059794400000,
					1.061799200000,
					1.062806800000,
					1.062909600000,
					1.062200000000,
					1.060735200000,
					1.058443600000,
					1.055224400000,
					1.050976800000,
					1.045600000000,
					1.039036900000,
					1.031360800000,
					1.022666200000,
					1.013047700000,
					1.002600000000,
					0.991367500000,
					0.979331400000,
					0.966491600000,
					0.952847900000,
					0.938400000000,
					0.923194000000,
					0.907244000000,
					0.890502000000,
					0.872920000000,
					0.854449900000,
					0.835084000000,
					0.814946000000,
					0.794186000000,
					0.772954000000,
					0.751400000000,
					0.729583600000,
					0.707588800000,
					0.685602200000,
					0.663810400000,
					0.642400000000,
					0.621514900000,
					0.601113800000,
					0.581105200000,
					0.561397700000,
					0.541900000000,
					0.522599500000,
					0.503546400000,
					0.484743600000,
					0.466193900000,
					0.447900000000,
					0.429861300000,
					0.412098000000,
					0.394644000000,
					0.377533300000,
					0.360800000000,
					0.344456300000,
					0.328516800000,
					0.313019200000,
					0.298001100000,
					0.283500000000,
					0.269544800000,
					0.256118400000,
					0.243189600000,
					0.230727200000,
					0.218700000000,
					0.207097100000,
					0.195923200000,
					0.185170800000,
					0.174832300000,
					0.164900000000,
					0.155366700000,
					0.146230000000,
					0.137490000000,
					0.129146700000,
					0.121200000000,
					0.113639700000,
					0.106465000000,
					0.099690440000,
					0.093330610000,
					0.087400000000,
					0.081900960000,
					0.076804280000,
					0.072077120000,
					0.067686640000,
					0.063600000000,
					0.059806850000,
					0.056282160000,
					0.052971040000,
					0.049818610000,
					0.046770000000,
					0.043784050000,
					0.040875360000,
					0.038072640000,
					0.035404610000,
					0.032900000000,
					0.030564190000,
					0.028380560000,
					0.026344840000,
					0.024452750000,
					0.022700000000,
					0.021084290000,
					0.019599880000,
					0.018237320000,
					0.016987170000,
					0.015840000000,
					0.014790640000,
					0.013831320000,
					0.012948680000,
					0.012129200000,
					0.011359160000,
					0.010629350000,
					0.009938846000,
					0.009288422000,
					0.008678854000,
					0.008110916000,
					0.007582388000,
					0.007088746000,
					0.006627313000,
					0.006195408000,
					0.005790346000,
					0.005409826000,
					0.005052583000,
					0.004717512000,
					0.004403507000,
					0.004109457000,
					0.003833913000,
					0.003575748000,
					0.003334342000,
					0.003109075000,
					0.002899327000,
					0.002704348000,
					0.002523020000,
					0.002354168000,
					0.002196616000,
					0.002049190000,
					0.001910960000,
					0.001781438000,
					0.001660110000,
					0.001546459000,
					0.001439971000,
					0.001340042000,
					0.001246275000,
					0.001158471000,
					0.001076430000,
					0.000999949300,
					0.000928735800,
					0.000862433200,
					0.000800750300,
					0.000743396000,
					0.000690078600,
					0.000640515600,
					0.000594502100,
					0.000551864600,
					0.000512429000,
					0.000476021300,
					0.000442453600,
					0.000411511700,
					0.000382981400,
					0.000356649100,
					0.000332301100,
					0.000309758600,
					0.000288887100,
					0.000269539400,
					0.000251568200,
					0.000234826100,
					0.000219171000,
					0.000204525800,
					0.000190840500,
					0.000178065400,
					0.000166150500,
					0.000155023600,
					0.000144621900,
					0.000134909800,
					0.000125852000,
					0.000117413000,
					0.000109551500,
					0.000102224500,
					0.000095394450,
					0.000089023900,
					0.000083075270,
					0.000077512690,
					0.000072313040,
					0.000067457780,
					0.000062928440,
					0.000058706520,
					0.000054770280,
					0.000051099180,
					0.000047676540,
					0.000044485670,
					0.000041509940
				}, 1
			);

			CIE1931XYZ1NmMatchingFunctionX (double minWaveLength, double[] amplitudes, double nmPerStep) : base(
				minWaveLength, amplitudes, nmPerStep
			) {}
		}
	}
}

