<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model frontend\models\LotSearch */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="lot-search">

    <?php $form = ActiveForm::begin([
        'action' => ['index'],
        'method' => 'get',
    ]); ?>

    <?= $form->field($model, 'id') ?>

    <?= $form->field($model, 'numer_lotu') ?>

    <?= $form->field($model, 'data_wylotu') ?>

    <?= $form->field($model, 'czas_lotu') ?>

    <?= $form->field($model, 'samolot_id') ?>

    <?php // echo $form->field($model, 'lotnisko_start') ?>

    <?php // echo $form->field($model, 'lotnisko_end') ?>

    <div class="form-group">
        <?= Html::submitButton('Search', ['class' => 'btn btn-primary']) ?>
        <?= Html::resetButton('Reset', ['class' => 'btn btn-default']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
