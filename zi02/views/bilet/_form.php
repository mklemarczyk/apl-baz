<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model app\models\Bilet */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="bilet-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'id')->textInput() ?>

    <?= $form->field($model, 'klasa')->textInput() ?>

    <?= $form->field($model, 'numer_miejsca')->textInput() ?>

    <?= $form->field($model, 'cena')->textInput(['maxlength' => 8]) ?>

    <?= $form->field($model, 'imie')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'nazwisko')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'lot_id')->textInput() ?>

    <?= $form->field($model, 'zakup_id')->textInput() ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? 'Create' : 'Update', ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
