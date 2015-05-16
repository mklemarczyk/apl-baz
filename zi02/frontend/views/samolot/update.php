<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Samolot */

$this->title = 'Zmień samolot: ' . ' ' . $model->nazwa;
$this->params['breadcrumbs'][] = ['label' => 'Samoloty', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->nazwa, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Zmień';
?>
<div class="samolot-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
