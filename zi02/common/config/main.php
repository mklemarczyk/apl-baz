<?php
return [
	'language' => 'pl',
	'sourceLanguage' => 'pl',
    'vendorPath' => dirname(dirname(__DIR__)) . '/vendor',
    'components' => [
        'cache' => [
            'class' => 'yii\caching\FileCache',
        ],
		'formatter' => [
			'dateFormat' => 'dd MMMM yyyy',
			'datetimeFormat' => 'dd MMMM yyyy, hh:mm',
			'decimalSeparator' => ',',
			'thousandSeparator' => ' ',
			'currencyCode' => 'PLN',
		],
    ],
];
