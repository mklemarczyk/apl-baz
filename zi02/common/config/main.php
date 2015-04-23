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
			'dateFormat' => 'dd.MM.yyyy',
			'decimalSeparator' => ',',
			'thousandSeparator' => ' ',
			'currencyCode' => 'PLN',
		],
    ],
];
