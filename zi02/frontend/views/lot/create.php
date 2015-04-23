<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Lot */

$this->title = 'Create Lot';
$this->params['breadcrumbs'][] = ['label' => 'Lots', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="lot-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'samoloty' => $samoloty,
		'lotniska' => $lotniska,
    ]) ?>

</div>
