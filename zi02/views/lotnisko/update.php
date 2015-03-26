<?php

use yii\helpers\Html;

/* @var $this yii\web\View */
/* @var $model app\models\Lotnisko */

$this->title = 'Update Lotnisko: ' . ' ' . $model->id;
$this->params['breadcrumbs'][] = ['label' => 'Lotniskos', 'url' => ['index']];
$this->params['breadcrumbs'][] = ['label' => $model->id, 'url' => ['view', 'id' => $model->id]];
$this->params['breadcrumbs'][] = 'Update';
?>
<div class="lotnisko-update">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
    ]) ?>

</div>
