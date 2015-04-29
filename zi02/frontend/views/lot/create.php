<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Lot */

$this->title = 'Stwórz lot';
$this->params['breadcrumbs'][] = ['label' => 'Loty', 'url' => ['index']];
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
