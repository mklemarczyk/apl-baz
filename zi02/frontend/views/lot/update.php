<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Lot */

$this->title = 'Zmień lot: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Loty', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Zmień';
?>
<div class="lot-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'samoloty' => $samoloty,
		'lotniska' => $lotniska,
    ]) ?>

</div>
