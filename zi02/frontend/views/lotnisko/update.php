<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model common\models\Lotnisko */

$this->title = 'Zmień lotnisko: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Lotniska', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Zmień';
?>
<div class="lotnisko-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
