using robotManager.Helpful;
using System;
using System.Collections.Generic;

public static class Egg
{
    public static List<Int32> ObjectEntry = new List<int>()
    {
        185915,
        185599
    };

    public static List<Vector3> VectorPath = new List<Vector3>()
    {
       new Vector3(130.609 ,620.6448 ,-5424.569, "Flying"),
new Vector3(129.4093 ,631.1644 ,-5414.808, "Flying"),
new Vector3(128.8907 ,642.8749 ,-5403.099, "Flying"),
new Vector3(128.6192 ,655.356 ,-5390.636, "Flying"),
new Vector3(128.2939 ,668.131 ,-5378.529, "Flying"),
new Vector3(128.4422 ,681.0003 ,-5366.568, "Flying"),
new Vector3(132.1867 ,692.6876 ,-5354.287, "Flying"),
new Vector3(138.6341 ,703.3333 ,-5341.693, "Flying"),
new Vector3(145.3206 ,713.8928 ,-5329.023, "Flying"),
new Vector3(151.9807 ,724.4107 ,-5316.402, "Flying"),
new Vector3(158.5554 ,734.7936 ,-5303.943, "Flying"),
new Vector3(165.1695 ,745.2388 ,-5291.41, "Flying"),
new Vector3(171.7113 ,755.5699 ,-5279.014, "Flying"),
new Vector3(178.4175 ,766.1605 ,-5266.306, "Flying"),
new Vector3(185.0579 ,776.6472 ,-5253.723, "Flying"),
new Vector3(188.4477 ,786.9921 ,-5239.938, "Flying"),
new Vector3(191.3693 ,795.8505 ,-5226.297, "Flying"),
new Vector3(191.0885 ,805.197 ,-5211.733, "Flying"),
new Vector3(189.1514 ,809.0769 ,-5194.666, "Flying"),
new Vector3(184.1442 ,807.3 ,-5177.774, "Flying"),
new Vector3(179.0362 ,804.8504 ,-5160.923, "Flying"),
new Vector3(173.9965 ,801.9899 ,-5144.208, "Flying"),
new Vector3(169.513 ,796.6413 ,-5127.821, "Flying"),
new Vector3(166.6348 ,789.6862 ,-5111.817, "Flying"),
new Vector3(164.4547 ,782.2775 ,-5096.037, "Flying"),
new Vector3(162.6865 ,774.6977 ,-5080.051, "Flying"),
new Vector3(161.1123 ,767.0891 ,-5064.001, "Flying"),
new Vector3(159.8605 ,760.1537 ,-5047.816, "Flying"),
new Vector3(158.5248 ,753.7392 ,-5031.27, "Flying"),
new Vector3(156.501 ,746.9017 ,-5014.718, "Flying"),
new Vector3(153.7259 ,739.3481 ,-4998.888, "Flying"),
new Vector3(150.6671 ,731.7314 ,-4983.223, "Flying"),
new Vector3(147.1093 ,731.2444 ,-4965.812, "Flying"),
new Vector3(143.5999 ,734.9752 ,-4949.007, "Flying"),
new Vector3(140.8133 ,743.584 ,-4933.925, "Flying"),
new Vector3(138.3609 ,755.5399 ,-4920.924, "Flying"),
new Vector3(135.903 ,767.5876 ,-4908.057, "Flying"),
new Vector3(133.4116 ,779.7333 ,-4895.143, "Flying"),
new Vector3(131.27 ,791.813 ,-4882.3, "Flying"),
new Vector3(129.2636 ,803.9888 ,-4869.354, "Flying"),
new Vector3(127.2848 ,815.9977 ,-4856.585, "Flying"),
new Vector3(124.8674 ,826.6285 ,-4842.614, "Flying"),
new Vector3(122.4474 ,833.204 ,-4826.21, "Flying"),
new Vector3(120.5178 ,835.7319 ,-4808.641, "Flying"),
new Vector3(118.3972 ,834.7842 ,-4790.881, "Flying"),
new Vector3(115.2953 ,831.3832 ,-4773.472, "Flying"),
new Vector3(109.2468 ,825.914 ,-4757.593, "Flying"),
new Vector3(101.3359 ,818.0835 ,-4743.506, "Flying"),
new Vector3(93.05137 ,807.9475 ,-4731.578, "Flying"),
new Vector3(84.74572 ,797.9086 ,-4719.459, "Flying"),
new Vector3(76.65321 ,789.4526 ,-4706.078, "Flying"),
new Vector3(68.72541 ,782.3338 ,-4691.907, "Flying"),
new Vector3(60.91463 ,778.3087 ,-4676.407, "Flying"),
new Vector3(53.18393 ,775.942 ,-4660.492, "Flying"),
new Vector3(45.64802 ,774.0217 ,-4644.68, "Flying"),
new Vector3(38.12 ,772.228 ,-4628.672, "Flying"),
new Vector3(30.90909 ,769.3464 ,-4612.508, "Flying"),
new Vector3(27.89503 ,755.6512 ,-4603.431, "Flying"),
new Vector3(28.72982 ,739.058 ,-4607.708, "Flying"),
new Vector3(32.668 ,725.483 ,-4618.306, "Flying"),
new Vector3(36.87297 ,712.3469 ,-4629.991, "Flying"),
new Vector3(41.02502 ,699.376 ,-4641.53, "Flying"),
new Vector3(44.22671 ,687.0774 ,-4653.577, "Flying"),
new Vector3(50.71244 ,677.5947 ,-4667.333, "Flying"),
new Vector3(57.91591 ,668.9424 ,-4680.685, "Flying"),
new Vector3(65.37202 ,659.9867 ,-4694.504, "Flying"),
new Vector3(72.69098 ,652.0342 ,-4708.455, "Flying"),
new Vector3(80.03881 ,648.2073 ,-4724.227, "Flying"),
new Vector3(87.36499 ,644.3917 ,-4739.951, "Flying"),
new Vector3(94.66952 ,643.4129 ,-4755.919, "Flying"),
new Vector3(102.1112 ,644.1086 ,-4772.341, "Flying"),
new Vector3(106.1834 ,643.6401 ,-4789.516, "Flying"),
new Vector3(110.7527 ,641.8358 ,-4806.931, "Flying"),
new Vector3(115.2421 ,639.4314 ,-4823.866, "Flying"),
new Vector3(119.5947 ,636.3069 ,-4840.871, "Flying"),
new Vector3(123.2208 ,633.5643 ,-4858.15, "Flying"),
new Vector3(126.8326 ,630.8323 ,-4875.362, "Flying"),
new Vector3(130.3983 ,628.1353 ,-4892.354, "Flying"),
new Vector3(134.0207 ,629.7571 ,-4909.714, "Flying"),
new Vector3(137.6326 ,629.4537 ,-4927.07, "Flying"),
new Vector3(141.2337 ,628.071 ,-4944.391, "Flying"),
new Vector3(144.8704 ,626.6747 ,-4961.882, "Flying"),
new Vector3(148.5036 ,625.2798 ,-4979.357, "Flying"),
new Vector3(152.1225 ,623.8903 ,-4996.763, "Flying"),
new Vector3(154.6911 ,622.3497 ,-5014.078, "Flying"),
new Vector3(153.18 ,619.8661 ,-5031.669, "Flying"),
new Vector3(150.1663 ,616.9135 ,-5048.766, "Flying"),
new Vector3(146.7858 ,613.8237 ,-5065.981, "Flying"),
new Vector3(143.3724 ,610.6736 ,-5083.216, "Flying"),
new Vector3(139.4066 ,608.1108 ,-5100.837, "Flying"),
new Vector3(135.6205 ,605.6701 ,-5118.01, "Flying"),
new Vector3(131.7548 ,602.2917 ,-5134.997, "Flying"),
new Vector3(127.8732 ,598.4409 ,-5151.783, "Flying"),
new Vector3(123.8971 ,594.1546 ,-5168.667, "Flying"),
new Vector3(119.9958 ,589.6052 ,-5185.084, "Flying"),
new Vector3(115.9008 ,583.8652 ,-5201.806, "Flying"),
new Vector3(111.9254 ,577.6705 ,-5217.933, "Flying"),
new Vector3(107.8861 ,571.3017 ,-5234.304, "Flying"),
new Vector3(103.9215 ,564.7864 ,-5250.384, "Flying"),
new Vector3(100.012 ,558.132 ,-5266.205, "Flying"),
new Vector3(96.09081 ,551.1288 ,-5282.031, "Flying"),
new Vector3(92.15421 ,544.098 ,-5297.92, "Flying"),
new Vector3(88.28319 ,537.1456 ,-5313.643, "Flying"),
new Vector3(85.42275 ,530.5986 ,-5330.167, "Flying"),
new Vector3(82.99685 ,524.5827 ,-5346.534, "Flying"),
new Vector3(80.49773 ,518.3826 ,-5363.424, "Flying"),
new Vector3(78.09504 ,512.0913 ,-5379.801, "Flying"),
new Vector3(75.78281 ,504.3853 ,-5395.554, "Flying"),
new Vector3(73.39432 ,494.4091 ,-5410.302, "Flying"),
new Vector3(71.23755 ,480.0274 ,-5420.477, "Flying"),
new Vector3(69.37483 ,463.0438 ,-5421.514, "Flying"),
new Vector3(68.63481 ,450.6763 ,-5409.059, "Flying"),
new Vector3(69.43073 ,446.4313 ,-5392.01, "Flying"),
new Vector3(71.64999 ,447.5498 ,-5374.465, "Flying"),
new Vector3(75.19105 ,450.6037 ,-5357.133, "Flying"),
new Vector3(78.82391 ,453.9983 ,-5340.373, "Flying"),
new Vector3(82.61613 ,458.6251 ,-5323.562, "Flying"),
new Vector3(86.45932 ,463.7567 ,-5306.959, "Flying"),
new Vector3(90.33687 ,468.969 ,-5290.314, "Flying"),
new Vector3(94.2953 ,474.283 ,-5273.758, "Flying"),
new Vector3(98.17659 ,479.9768 ,-5257.009, "Flying"),
new Vector3(101.8797 ,485.7757 ,-5240.842, "Flying"),
new Vector3(105.6297 ,491.5858 ,-5224.481, "Flying"),
new Vector3(109.4049 ,496.3885 ,-5207.793, "Flying"),
new Vector3(113.1305 ,500.2751 ,-5191.068, "Flying"),
new Vector3(116.7781 ,503.608 ,-5173.843, "Flying"),
new Vector3(119.9787 ,506.0904 ,-5156.531, "Flying"),
new Vector3(123.1775 ,508.546 ,-5139.161, "Flying"),
new Vector3(126.3607 ,510.9894 ,-5121.875, "Flying"),
new Vector3(129.5728 ,513.4571 ,-5104.419, "Flying"),
new Vector3(132.012 ,516.0406 ,-5087.056, "Flying"),
new Vector3(133.7314 ,518.7542 ,-5069.39, "Flying"),
new Vector3(134.5777 ,521.5824 ,-5051.739, "Flying"),
new Vector3(134.8848 ,524.5309 ,-5034.102, "Flying"),
new Vector3(135.2303 ,525.1564 ,-5016.364, "Flying"),
new Vector3(135.4235 ,524.9634 ,-4998.429, "Flying"),
new Vector3(135.6152 ,524.772 ,-4980.633, "Flying"),
new Vector3(135.8085 ,524.579 ,-4962.698, "Flying"),
new Vector3(136.0013 ,524.3865 ,-4944.797, "Flying"),
new Vector3(132.6382 ,521.0657 ,-4928.028, "Flying"),
new Vector3(128.879 ,515.3533 ,-4911.635, "Flying"),
new Vector3(125.3234 ,509.6095 ,-4895.19, "Flying"),
new Vector3(122.9666 ,503.5229 ,-4878.751, "Flying"),
new Vector3(120.8673 ,497.0259 ,-4862.411, "Flying"),
new Vector3(118.6398 ,490.0952 ,-4846.134, "Flying"),
new Vector3(115.9106 ,482.7604 ,-4830.189, "Flying"),
new Vector3(113.1414 ,475.3517 ,-4814.168, "Flying"),
new Vector3(110.4291 ,465.2533 ,-4800.167, "Flying"),
new Vector3(107.6272 ,452.3748 ,-4787.794, "Flying"),

new Vector3(104.457 ,439.1541 ,-4776.387, "Flying"),

new Vector3(102.1877 ,424.1785 ,-4767.015, "Flying"),

new Vector3(100.8682 ,409.0403 ,-4756.936, "Flying"),

new Vector3(99.67537 ,394.1097 ,-4747.457, "Flying"),

new Vector3(98.12186 ,378.0305 ,-4740.128, "Flying"),

new Vector3(96.67755 ,361.424 ,-4734.127, "Flying"),

new Vector3(95.40299 ,344.2392 ,-4730.139, "Flying"),

new Vector3(94.40577 ,326.6701 ,-4728.333, "Flying"),

new Vector3(93.65676 ,308.8387 ,-4729.175, "Flying"),

new Vector3(93.31596 ,294.8172 ,-4739.136, "Flying"),

new Vector3(94.52641 ,290.3191 ,-4755.99, "Flying"),

new Vector3(97.92412 ,291.5835 ,-4773.445, "Flying"),

new Vector3(102.4976 ,294.191 ,-4790.24, "Flying"),

new Vector3(107.4538 ,297.0712 ,-4807.143, "Flying"),

new Vector3(113.4336 ,299.7679 ,-4823.552, "Flying"),

new Vector3(119.7802 ,301.7303 ,-4840.063, "Flying"),

new Vector3(126.0945 ,303.6253 ,-4856.538, "Flying"),

new Vector3(132.3566 ,305.5563 ,-4873.085, "Flying"),

new Vector3(138.6371 ,307.493 ,-4889.681, "Flying"),

new Vector3(144.9053 ,309.4624 ,-4906.24, "Flying"),

new Vector3(151.1398 ,311.4622 ,-4922.657, "Flying"),

new Vector3(158.0662 ,313.9743 ,-4938.876, "Flying"),

new Vector3(165.0479 ,316.1884 ,-4955.038, "Flying"),

new Vector3(171.483 ,318.8631 ,-4971.316, "Flying"),

new Vector3(177.8516 ,322.6498 ,-4987.431, "Flying"),

new Vector3(184.2326 ,328.8071 ,-5002.902, "Flying"),

new Vector3(190.645 ,335.0386 ,-5018.431, "Flying"),

new Vector3(196.9634 ,342.8938 ,-5032.928, "Flying"),

new Vector3(203.3757 ,350.8658 ,-5047.64, "Flying"),

new Vector3(208.1117 ,358.3683 ,-5062.826, "Flying"),

new Vector3(214.8361 ,365.2532 ,-5077.504, "Flying"),

new Vector3(221.9841 ,371.34 ,-5092.613, "Flying"),

new Vector3(223.7995 ,375.2319 ,-5109.516, "Flying"),

new Vector3(216.6875 ,378.4514 ,-5125.595, "Flying"),

new Vector3(210.3043 ,378.646 ,-5131.778, "Flying"),

new Vector3(203.5117 ,378.7408 ,-5138.093, "Flying"),

new Vector3(196.7887 ,378.8207 ,-5144.251, "Flying"),

new Vector3(190.156 ,378.9008 ,-5150.429, "Flying"),

new Vector3(183.688 ,378.9689 ,-5156.729, "Flying"),

new Vector3(177.5855 ,378.7637 ,-5163.066, "Flying"),

new Vector3(166.6736 ,376.2677 ,-5177.013, "Flying"),

new Vector3(156.5754 ,373.1558 ,-5191.355, "Flying"),

new Vector3(147.2395 ,369.9207 ,-5206.049, "Flying"),

new Vector3(138.1467 ,366.6536 ,-5221.204, "Flying"),

new Vector3(129.4725 ,363.3857 ,-5236.519, "Flying"),

new Vector3(121.2751 ,359.7755 ,-5251.974, "Flying"),

new Vector3(113.4164 ,353.619 ,-5266.988, "Flying"),

new Vector3(105.6779 ,346.3804 ,-5281.647, "Flying"),

new Vector3(100.5939 ,336.555 ,-5295.307, "Flying"),

new Vector3(96.15545 ,322.5482 ,-5305.856, "Flying"),

new Vector3(92.41871 ,308.6877 ,-5316.375, "Flying"),

new Vector3(88.70114 ,291.4581 ,-5318.486, "Flying"),

new Vector3(86.38765 ,280.3684 ,-5299.402, "Flying"),

new Vector3(86.66663 ,275.0889 ,-5282.724, "Flying"),

new Vector3(94.1042 ,269.1774 ,-5268.971, "Flying"),

new Vector3(98.54242 ,261.7428 ,-5253.445, "Flying"),

new Vector3(103.4369 ,254.7853 ,-5237.857, "Flying"),

new Vector3(109.5943 ,248.9851 ,-5222.38, "Flying"),

new Vector3(118.3718 ,244.1192 ,-5207.27, "Flying"),

new Vector3(129.1041 ,239.7976 ,-5193.719, "Flying"),

new Vector3(140.5432 ,235.7601 ,-5180.889, "Flying"),

new Vector3(151.0138 ,231.8766 ,-5166.959, "Flying"),

new Vector3(158.2668 ,227.4613 ,-5151.58, "Flying"),

new Vector3(162.9343 ,221.7645 ,-5135.214, "Flying"),

new Vector3(164.9834 ,216.8835 ,-5118.422, "Flying"),

new Vector3(166.6528 ,212.2417 ,-5101.159, "Flying"),

new Vector3(167.7518 ,207.1465 ,-5084.177, "Flying"),

new Vector3(166.1238 ,201.7532 ,-5066.963, "Flying"),

new Vector3(164.2503 ,197.2415 ,-5050.005, "Flying"),

new Vector3(161.612 ,193.677 ,-5032.377, "Flying"),

new Vector3(158.2386 ,190.6859 ,-5015.38, "Flying"),

new Vector3(153.8575 ,187.5591 ,-4998.348, "Flying"),

new Vector3(148.0978 ,182.9603 ,-4982.067, "Flying"),

new Vector3(141.0246 ,178.2966 ,-4966.338, "Flying"),

new Vector3(133.6914 ,173.9474 ,-4950.835, "Flying"),

new Vector3(126.3093 ,169.7207 ,-4935.223, "Flying"),

new Vector3(118.9507 ,163.7768 ,-4920.287, "Flying"),

new Vector3(111.5849 ,152.9843 ,-4908.46, "Flying"),

new Vector3(105.686 ,137.1735 ,-4904.364, "Flying"),

new Vector3(106.3696 ,119.4081 ,-4905.146, "Flying"),

new Vector3(107.1328 ,101.5929 ,-4905.958, "Flying"),

new Vector3(113.382 ,86.22186 ,-4906.657, "Flying"),

new Vector3(119.7301 ,80.0937 ,-4907.864, "Flying"),

new Vector3(122.3032 ,64.10454 ,-4912.827, "Flying"),

new Vector3(123.0687 ,50.81218 ,-4922.403, "Flying"),

new Vector3(123.8297 ,47.71085 ,-4939.614, "Flying"),

new Vector3(124.5839 ,49.80858 ,-4957.112, "Flying"),

new Vector3(125.3389 ,51.9084 ,-4974.628, "Flying"),

new Vector3(126.1007 ,54.02695 ,-4992.3, "Flying"),

new Vector3(126.8579 ,56.13301 ,-5009.868, "Flying"),

new Vector3(127.6308 ,56.61586 ,-5027.844, "Flying"),

new Vector3(128.4068 ,61.41264 ,-5045.329, "Flying"),

new Vector3(129.1722 ,62.70225 ,-5063.149, "Flying"),

new Vector3(129.9317 ,63.73183 ,-5080.866, "Flying"),

new Vector3(130.6905 ,64.76041 ,-5098.564, "Flying"),

new Vector3(131.4544 ,65.79608 ,-5116.386, "Flying"),

new Vector3(129.3785 ,65.71977 ,-5134.3, "Flying"),

new Vector3(128.1278 ,65.18701 ,-5151.923, "Flying"),

new Vector3(126.8535 ,64.64423 ,-5169.877, "Flying"),

new Vector3(125.3462 ,64.3896 ,-5187.965, "Flying"),

new Vector3(122.6196 ,66.5965 ,-5205.609, "Flying"),

new Vector3(120.1395 ,66.07891 ,-5223.381, "Flying"),

new Vector3(118.5649 ,63.80605 ,-5240.942, "Flying"),

new Vector3(117.2853 ,58.6176 ,-5257.885, "Flying"),

new Vector3(115.9541 ,50.1191 ,-5273.613, "Flying"),

new Vector3(114.573 ,40.88413 ,-5288.887, "Flying"),

new Vector3(113.2599 ,31.75282 ,-5303.984, "Flying"),

new Vector3(113.1515 ,25.27531 ,-5320.856, "Flying"),

new Vector3(114.2272 ,21.45133 ,-5338.036, "Flying"),

new Vector3(115.7137 ,18.03141 ,-5355.277, "Flying"),

new Vector3(117.2164 ,14.57416 ,-5372.707, "Flying"),

new Vector3(118.7268 ,11.0897 ,-5390.273, "Flying"),

new Vector3(120.2135 ,7.577529 ,-5407.979, "Flying"),

new Vector3(121.2432 ,3.985786 ,-5425.289, "Flying"),

new Vector3(121.7373 ,0.2851189 ,-5442.58, "Flying"),

new Vector3(121.1119 ,-4.054325 ,-5460.032, "Flying"),

new Vector3(119.2182 ,-13.17148 ,-5474.936, "Flying"),

new Vector3(116.9724 ,-29.51099 ,-5479.102, "Flying"),

new Vector3(115.5475 ,-45.27168 ,-5471.395, "Flying"),

new Vector3(114.3631 ,-56.82218 ,-5458.274, "Flying"),

new Vector3(112.9221 ,-66.6516 ,-5443.089, "Flying"),

new Vector3(111.3701 ,-71.82104 ,-5426.104, "Flying"),

new Vector3(109.8225 ,-71.16198 ,-5408.166, "Flying"),

new Vector3(108.4878 ,-71.16464 ,-5390.331, "Flying"),

new Vector3(107.4886 ,-71.34872 ,-5372.65, "Flying"),

new Vector3(106.5705 ,-71.45268 ,-5355.104, "Flying"),

new Vector3(106.1462 ,-70.74884 ,-5337.174, "Flying"),

new Vector3(105.8565 ,-69.45847 ,-5319.584, "Flying"),

new Vector3(106.0379 ,-68.31934 ,-5301.8, "Flying"),

new Vector3(108.0341 ,-68.2873 ,-5284.203, "Flying"),

new Vector3(110.0903 ,-68.26566 ,-5266.612, "Flying"),

new Vector3(112.1932 ,-68.24352 ,-5248.623, "Flying"),

new Vector3(114.2392 ,-68.22199 ,-5231.119, "Flying"),

new Vector3(116.3259 ,-68.20004 ,-5213.268, "Flying"),

new Vector3(121.0555 ,-67.7504 ,-5196.98, "Flying"),

new Vector3(127.3416 ,-66.96036 ,-5190.746, "Flying"),

new Vector3(133.764 ,-66.44234 ,-5184.349, "Flying"),

new Vector3(138.7021 ,-65.1485 ,-5167.392, "Flying"),

new Vector3(143.1921 ,-63.85008 ,-5150.255, "Flying"),

new Vector3(147.2243 ,-62.50408 ,-5132.848, "Flying"),

new Vector3(149.6401 ,-61.68507 ,-5115.469, "Flying"),

new Vector3(149.9439 ,-60.55145 ,-5097.784, "Flying"),

new Vector3(146.6431 ,-57.2577 ,-5080.663, "Flying"),

new Vector3(142.5785 ,-52.90962 ,-5063.834, "Flying"),

new Vector3(138.8952 ,-49.15022 ,-5046.708, "Flying"),

new Vector3(136.0449 ,-46.63585 ,-5029.482, "Flying"),

new Vector3(133.4209 ,-46.03418 ,-5011.952, "Flying"),

new Vector3(130.3734 ,-51.69933 ,-4995.364, "Flying"),

new Vector3(132.8301 ,-61.17112 ,-4982.646, "Flying"),

new Vector3(137.126 ,-71.87215 ,-4970.204, "Flying"),

new Vector3(138.3102 ,-83.80852 ,-4957.082, "Flying"),

new Vector3(137.4117 ,-95.70129 ,-4944.101, "Flying"),

new Vector3(134.1227 ,-105.7216 ,-4929.811, "Flying"),

new Vector3(130.2852 ,-113.2212 ,-4914.05, "Flying"),

new Vector3(126.3745 ,-111.4885 ,-4897.13, "Flying"),

new Vector3(123.2167 ,-99.0773 ,-4885.024, "Flying"),

new Vector3(121.9746 ,-82.15469 ,-4879.643, "Flying"),

new Vector3(122.3081 ,-64.47466 ,-4881.474, "Flying"),

new Vector3(123.3516 ,-48.47307 ,-4888.641, "Flying"),

new Vector3(124.3612 ,-34.36689 ,-4899.382, "Flying"),

new Vector3(125.736 ,-19.88717 ,-4909.699, "Flying"),

new Vector3(127.1464 ,-5.480986 ,-4919.963, "Flying"),

new Vector3(128.9583 ,9.107855 ,-4930.453, "Flying"),

new Vector3(131.1541 ,23.43823 ,-4940.896, "Flying"),

new Vector3(133.5523 ,37.6341 ,-4951.269, "Flying"),

new Vector3(136.0652 ,51.96692 ,-4961.726, "Flying"),

new Vector3(138.9202 ,66.46281 ,-4972.173, "Flying"),

new Vector3(141.908 ,80.78068 ,-4982.282, "Flying"),

new Vector3(144.9364 ,95.02055 ,-4992.274, "Flying"),

new Vector3(147.9918 ,109.3875 ,-5002.355, "Flying"),

new Vector3(151.0172 ,123.6336 ,-5012.308, "Flying"),

new Vector3(154.0517 ,137.9257 ,-5022.286, "Flying"),

new Vector3(157.18 ,152.4718 ,-5032.428, "Flying"),

new Vector3(161.5991 ,166.8498 ,-5042.39, "Flying"),

new Vector3(165.7267 ,180.948 ,-5052.093, "Flying"),

new Vector3(169.8607 ,195.3338 ,-5061.881, "Flying"),

new Vector3(173.4644 ,209.8721 ,-5071.46, "Flying"),

new Vector3(176.761 ,224.4801 ,-5081.045, "Flying"),

new Vector3(179.7458 ,239.3624 ,-5090.797, "Flying"),

new Vector3(181.9827 ,254.0788 ,-5100.639, "Flying"),

new Vector3(183.7525 ,268.2068 ,-5111.197, "Flying"),

new Vector3(184.6891 ,282.6033 ,-5121.706, "Flying"),

new Vector3(185.1353 ,296.7533 ,-5132.257, "Flying"),

new Vector3(184.543 ,310.4324 ,-5143.802, "Flying"),

new Vector3(182.9367 ,323.3205 ,-5155.992, "Flying"),

new Vector3(180.9739 ,335.5488 ,-5168.698, "Flying"),

new Vector3(179.0056 ,347.7313 ,-5181.522, "Flying"),

new Vector3(176.6805 ,360.0471 ,-5194.637, "Flying"),

new Vector3(173.3597 ,373.1401 ,-5205.961, "Flying"),

new Vector3(170.0278 ,388.5591 ,-5214.065, "Flying"),

new Vector3(166.293 ,405.728 ,-5218.17, "Flying"),

new Vector3(162.744 ,423.1424 ,-5220.721, "Flying"),

new Vector3(159.2904 ,440.692 ,-5223.221, "Flying"),

new Vector3(155.867 ,458.0885 ,-5225.699, "Flying"),

new Vector3(152.4569 ,475.4328 ,-5228.05, "Flying"),

new Vector3(149.3271 ,491.4775 ,-5234.271, "Flying"),

new Vector3(146.5907 ,505.1999 ,-5245.589, "Flying"),

new Vector3(143.9464 ,516.9619 ,-5258.469, "Flying"),

new Vector3(141.0074 ,527.5369 ,-5272.603, "Flying"),

new Vector3(138.2041 ,535.7736 ,-5287.979, "Flying"),

new Vector3(135.6572 ,542.8187 ,-5304.102, "Flying"),

new Vector3(133.3555 ,548.907 ,-5320.645, "Flying"),

new Vector3(131.4799 ,554.6952 ,-5337.257, "Flying"),

new Vector3(129.9475 ,560.475 ,-5354.335, "Flying"),

new Vector3(128.5754 ,566.0755 ,-5371.098, "Flying"),

new Vector3(127.3971 ,571.6031 ,-5387.882, "Flying"),

new Vector3(126.7671 ,578.3149 ,-5404.676, "Flying"),

new Vector3(127.5011 ,591.1853 ,-5416.903, "Flying"),

new Vector3(128.8315 ,607.5713 ,-5423.407, "Flying"),
    };
}
