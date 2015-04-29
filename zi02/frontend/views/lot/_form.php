<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Lot */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="lot-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'numer_lotu')->textInput(['maxlength' => 20]) ?>

    <?= $form->field($model, 'data_wylotu')->textInput() ?>

    <?= $form->field($model, 'czas_lotu')->textInput() ?>

    <?= $form->field($model, 'samolot_id')->dropDownList($samoloty)->label('Samolot') ?>

    <?= $form->field($model, 'lotnisko_start')->dropDownList($lotniska)->label('Lotnisko wylotu') ?>

    <?= $form->field($model, 'lotnisko_end')->dropDownList($lotniska)->label('Lotnisko przylotu') ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? 'Stwórz' : 'Zapisz', ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
