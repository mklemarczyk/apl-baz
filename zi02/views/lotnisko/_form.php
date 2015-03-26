<?php

use yii\helpers\Html;
use yii\widgets\ActiveForm;

/* @var $this yii\web\View */
/* @var $model app\models\Lotnisko */
/* @var $form yii\widgets\ActiveForm */
?>

<div class="lotnisko-form">

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($model, 'id')->textInput() ?>

    <?= $form->field($model, 'nazwa')->textInput(['maxlength' => 50]) ?>

    <?= $form->field($model, 'miasto')->textInput(['maxlength' => 50]) ?>

    <?= $form->field($model, 'kraj')->textInput(['maxlength' => 50]) ?>

    <div class="form-group">
        <?= Html::submitButton($model->isNewRecord ? 'Create' : 'Update', ['class' => $model->isNewRecord ? 'btn btn-success' : 'btn btn-primary']) ?>
    </div>

    <?php ActiveForm::end(); ?>

</div>
