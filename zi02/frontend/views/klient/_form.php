<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model common\models\Klient */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="klient-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'imie')->textInput(['maxlength' => 255]) ?>

    <?= $form->field($model, 'nazwisko')->textInput(['maxlength' => 255]) ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? 'Stwórz' : 'Zapisz', ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
