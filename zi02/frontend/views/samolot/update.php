<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Samolot */

$this->title = 'Update Samolot: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Samolots', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Update';
?>
<div class="samolot-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
